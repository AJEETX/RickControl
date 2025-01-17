﻿using System.ComponentModel.DataAnnotations;
using app.Model.ViewModel.Base;

namespace app.Model.ViewModel.UnitOfMeasure
{
    public class SearchUnitOfMeasureViewModel : BaseViewModel
    {
        [Display(Name = "Case type Name")]
        public string UnitOfMeasureName { get; set; }
        [Display(Name = "Case type code")]
        public string Isocode { get; set; }
    }
}
