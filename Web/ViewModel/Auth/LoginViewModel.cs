using app.Model.ViewModel.Base;
using System.ComponentModel.DataAnnotations;

namespace app.Model.ViewModel.Auth
{
    public class LoginViewModel : BaseViewModel
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

        public bool Remember { get; set; }
    }
}
