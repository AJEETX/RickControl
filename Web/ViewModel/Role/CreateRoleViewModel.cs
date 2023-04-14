using app.Model.ViewModel.Base;
using System.ComponentModel.DataAnnotations;

namespace app.Model.ViewModel.Role
{
    public class CreateRoleViewModel : BaseViewModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }        
        [Required]
        [MaxLength(3)]
        [Display(Name = "Role Code")]
        public string RoleCode { get; set; }                
    }
}