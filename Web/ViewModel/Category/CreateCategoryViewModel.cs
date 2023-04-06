﻿using app.Model.ViewModel.Base;
using System.ComponentModel.DataAnnotations;

namespace app.Model.ViewModel.Category
{
    public class CreateCategoryViewModel : BaseViewModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Agency Name")]
        public string CategoryName { get; set; }
    }
}
