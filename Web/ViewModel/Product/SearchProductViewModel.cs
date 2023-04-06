using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using app.Model.ViewModel.Base;

namespace app.Model.ViewModel.Product
{
    public class SearchProductViewModel : BaseViewModel
    {
      
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
 
        [Display(Name = "Barcode")]
        public string Barcode { get; set; }

        [Display(Name = "Category")]
        public int? CategoryId { get; set; }
  
        [Display(Name = "Unit Of Measure")]
        public int? UnitOfMeasureId { get; set; }

        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> UnitOfMeasureList { get; set; }
    }
}
