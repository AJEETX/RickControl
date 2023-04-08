using System.ComponentModel.DataAnnotations;
using app.Model.ViewModel.Base;

namespace app.Model.ViewModel.Store
{
    public  class EditStoreViewModel:BaseViewModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Company Name")]
        public string StoreName { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Company Code")]
        public string StoreCode { get; set; }
    }
}
