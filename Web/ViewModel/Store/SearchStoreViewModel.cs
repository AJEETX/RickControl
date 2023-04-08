using System.ComponentModel.DataAnnotations;
using app.Model.ViewModel.Base;

namespace app.Model.ViewModel.Store
{
    public class SearchStoreViewModel : BaseViewModel
    {

        [Display(Name = "Company Name")]
        public string StoreName { get; set; }


        [Display(Name = "Company Code")]
        public string StoreCode { get; set; }
    }
}
