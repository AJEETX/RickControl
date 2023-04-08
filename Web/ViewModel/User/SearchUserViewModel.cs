using app.Data.Entity;
using app.Model.ViewModel.Base;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace app.Model.ViewModel.User
{
    public class SearchUserViewModel : BaseViewModel
    {

        [Display]
        public string Email { get; set; }

        [Display]
        public string Name { get; set; }

        [Display]
        public string Surname { get; set; }
        public int StoreId { get; set; }
        public int? EmployeeTypeId {get; set;}
        
        public IEnumerable<SelectListItem> CompanyList { get; set; }
        public IEnumerable<SelectListItem> EmployeeTypeList { get; set; }
    }
}
