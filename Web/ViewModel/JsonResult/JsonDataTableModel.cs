namespace app.Model.ViewModel.JsonResult
{
    public class JsonDataTableModel: JsonResultModel
    {
        public int iTotalRecords { get; set; }
        public int iTotalDisplayRecords { get; set; }
        public object aaData { get; set; }
    }
}
