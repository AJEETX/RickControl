using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using app.Data.Entity;
using app.Model.ViewModel.Base;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace app.Model.ViewModel.User
{
    public class EditUserViewModel : BaseViewModel
    {
        [Required]
        [MaxLength(50)]
        [Display]
        [EmailAddress]
        public string Email { get; set; }

   
        [MaxLength(18)]
        [Display]
        public string Password { get; set; }

        [Required]
        [MaxLength(30)]
        [Display]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        [Display]
        public string Surname { get; set; }
        [Display(Name = "Company name")]
        public int? StoreId { get; set; }
        [Display(Name = "Agency name")]
        public int? CategoryId { get; set; }            
        [Display(Name = "Employee type")]
        public int? EmployeeTypeId { get; set; }
        public IEnumerable<SelectListItem> UserRoles { get; set; }
        [Display(Name = "User roles")]
        public IList<string> SelectedUserRoleIds { get; set; } = new List<string>();
        public IEnumerable<SelectListItem> AgencyList { get; set; }
        public IEnumerable<SelectListItem> CompanyList { get; set; }
        public IEnumerable<SelectListItem> EmployeeTypeList { get; set; }     
    }
}
