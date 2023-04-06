using System.ComponentModel.DataAnnotations;
using app.Model.ViewModel.Base;

namespace app.Model.ViewModel.Category
{
    public class SearchCategoryViewModel: BaseViewModel
    {

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

    }
}
