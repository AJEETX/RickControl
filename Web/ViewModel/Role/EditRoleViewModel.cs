﻿using app.Model.ViewModel.Base;
using System.ComponentModel.DataAnnotations;

namespace app.Model.ViewModel.Role
{
    public class EditRoleViewModel : BaseViewModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }
}