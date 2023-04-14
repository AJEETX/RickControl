using System.ComponentModel.DataAnnotations;
using app.Model.ViewModel.Base;

namespace app.Model.ViewModel.Role
{
    public class SearchRoleViewModel: BaseViewModel
    {

        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
        [Display(Name = "Role Code")]
        public string RoleCode { get; set; }        

    }
}
