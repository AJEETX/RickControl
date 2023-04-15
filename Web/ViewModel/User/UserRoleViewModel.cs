using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using app.Data.Entity;
using app.Model.ViewModel.Base;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace app.Model.ViewModel.User
{
    public class UserRoleViewModel
    {
        public int? UserId {get;set;}
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
    }
}