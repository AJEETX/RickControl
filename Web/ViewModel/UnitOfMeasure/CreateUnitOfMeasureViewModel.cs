using System.ComponentModel.DataAnnotations;
using app.Model.ViewModel.Base;

namespace app.Model.ViewModel.UnitOfMeasure
{
    public class CreateUnitOfMeasureViewModel: BaseViewModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Unit of Measure Name")]
        public string UnitOfMeasureName { get; set; }


        [Required]
        [MaxLength(3)]
        [Display(Name = "Unit of Measure Short Code")]
        public string Isocode { get; set; }

    }
}
