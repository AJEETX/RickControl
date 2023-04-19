
$(document).ready(function () {
    var datatable = $('#datatable').dataTable({
        "searching": false,
        "iDisplayLength": 10,
        "ordering": false,
        "lengthChange": false,
        "bServerSide": true,
        "processing": true,
        "paging": true,
        "sAjaxSource": "/Product/List",
        "info": true,
        "fnServerData": function (sSource, aoData, fnCallback, oSettings) {
            aoData.push(
                { "name": "returnformat", "value": "plain" },
                { "name": "ProductName", "value": $('input[name="ProductName"]').val() },
                { "name": "Barcode", "value": $('input[name="Barcode"]').val() },
                { "name": "CategoryId", "value": $('select[name="CategoryId"]').val() },
                { "name": "Status", "value": $('select[name="Status"]').val() },
                { "name": "UnitOfMeasureId", "value": $('select[name="UnitOfMeasureId"]').val() }
            );
            $.ajax({
                "dataType": 'json',
                "type": "GET",
                "url": sSource,
                "data": aoData,
                "success": function (data) {
                    if (data.IsSucceeded == true) {
                        fnCallback(data);
                    }
                    else {
                        toastr.error(data.UserMessage);
                    }
                }
            });
        },
        columnDefs: [{
            orderable: false,
            className: 'select-checkbox',
            targets: 0
        }],
        select: {
            style: 'os',
            selector: 'td:first-child'
        },
        order: [
            [1, 'asc']
        ],
        aoColumns:
            [
                {
                    "sDefaultContent": "",
                    "bSortable": false,
                    "mRender": function (data, type, row) {
                        var cbox = '<input type="checkbox" style=display:' + adminRole + '; name="id[]" value="' + $('<div/>').text(data).html() + '">';
                        return cbox;
                    }
                },
                //<input type="checkbox" style=display:' + adminRole + '; name="id[]" value="' + $('<div/>').text(data).html() + '">
                {
                    "sDefaultContent": "",
                    "bSortable": true,
                    "mRender": function (data, type, row) {
                        var img = '<img src="upload/' + row.ImageDisplay + '" src height="30" alt="No image" />';
                        return img;
                    }
                },
                {
                    mDataProp: "ProductName"
                },
                {
                    mDataProp: "Barcode"
                },
                {
                    mDataProp: "Price"
                },
                {
                    mDataProp: "CategoryName"
                },
                {
                    mDataProp: "UnitOfMeasureName"
                },
                {
                    mDataProp: "Status"
                },
                {
                    "sDefaultContent": "",
                    "bSortable": false,
                    "mRender": function (data, type, row) {
                        var buttons = "";
                        buttons += '<a href="/Product/View/' + row.Id + '" style=display:' + viewRole + '; class="btn btn-xs btn-warning"><i class="fa fa-search"></i> View</a>&nbsp;'
                        buttons += '<a href="/Product/Edit/' + row.Id + '" style=display:' + adminRole + '; class="btn btn-xs btn-warning"><i class="fas fa-pen"></i> Edit</a>&nbsp;'
                        buttons += '<a onclick="deleteRow(this,' + row.Id + ')" style=display:' + adminRole + '; class="btn btn-xs btn-danger"><i class="fas fa-trash"></i> Delete</a>'
                        // buttons += '<input type="checkbox" style=display:' + adminRole + '; name="id[]" value="' + $('<div/>').text(data).html() + '">'
                        return buttons;
                    }
                }
            ],
            select: {
                style: 'os',
                selector: 'td:first-child'
            },
            order: [
                [1, 'asc']
            ]
    });

    datatable.on("click", "th.select-checkbox", function() {
        if ($("th.select-checkbox").hasClass("selected")) {
            datatable.rows().deselect();
            $("th.select-checkbox").removeClass("selected");
        } else {
            datatable.rows().select();
            $("th.select-checkbox").addClass("selected");
        }
    }).on("select deselect", function() {
        ("Some selection or deselection going on")
        if (datatable.rows({
                selected: true
            }).count() !== datatable.rows().count()) {
            $("th.select-checkbox").removeClass("selected");
        } else {
            $("th.select-checkbox").addClass("selected");
        }
    });

    
    $("#btnFilter").click(function () {
        datatable.fnFilter();
    });

    $("#btnClear").click(function () {
        $('div.dataTable-search-form').clearForm();
        datatable.fnFilter();
    });


    $('.enter-keyup').keypress(function (event) {
        var keycode = (event.keyCode ? event.keyCode : event.which);
        if (keycode == '13') {
            datatable.fnFilter();
        }
    });

});



function deleteRow(row, id) {

    $.ajax({
        url: '/Product/Delete/' + id,
        type: "POST",
        async: false,
        success: function (data) {
            if (data.IsSucceeded) {
                var aPos = $('#datatable').dataTable().fnGetPosition(row);
                $('#datatable').dataTable().fnDeleteRow(aPos);
                toastr.success(data.UserMessage);
            }
            else {
                toastr.error(data.UserMessage);
            }
        }
    });
}

