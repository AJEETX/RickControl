using System.ComponentModel.DataAnnotations;
using app.Model.ViewModel.Base;

namespace app.Model.ViewModel.UnitOfMeasure
{
    public class EditUnitOfMeasureViewModel : BaseViewModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Investigation type Name")]
        public string UnitOfMeasureName { get; set; }


        [Required]
        [MaxLength(3)]
        [Display(Name = "Investigation type Short Code")]
        public string Isocode { get; set; }
    }
}
