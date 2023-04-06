using System.ComponentModel.DataAnnotations;
using app.Data.Entity;
using app.Model.ViewModel.Base;

namespace app.Model.ViewModel.User
{
    public class CreateUserViewModel: BaseViewModel
    {
        [Required]
        [MaxLength(50)]
        [Display]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
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

        public Organisation? Organisation { get; set; }
        public EmployeeType? EmployeeType { get; set; }
    }
}
