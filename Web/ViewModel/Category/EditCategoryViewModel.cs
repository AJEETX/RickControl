using app.Model.ViewModel.Base;
using System.ComponentModel.DataAnnotations;

namespace app.Model.ViewModel.Category
{
    public class EditCategoryViewModel : BaseViewModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    }
}
