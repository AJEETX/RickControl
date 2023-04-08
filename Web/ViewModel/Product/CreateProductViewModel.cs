using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using app.Model.ViewModel.Base;

namespace app.Model.ViewModel.Product
{
    public class CreateProductViewModel : BaseViewModel
    {

        [Required]
        [MaxLength(100)]
        [Display(Name = "Claim case Name")]
        public string ProductName { get; set; }

        [MaxLength(50)]
        [Display(Name = "code")]
        public string Barcode { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Image")]
        public string Image { get; set; }

        [Display(Name = "Image")]
        [RegularExpression(@"^.*\.(jpg|JPG|png|PNG|jpeg|JPEG)$")]
        public IFormFile ImageFile { get; set; }

        [Display(Name = "Price")]
        public decimal? Price { get; set; }

        [Display(Name = "Agency")]
        public int? CategoryId { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        [Required]
        [Display(Name = "Case type")]
        public int UnitOfMeasureId { get; set; }

        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> UnitOfMeasureList { get; set; }
    }
}
