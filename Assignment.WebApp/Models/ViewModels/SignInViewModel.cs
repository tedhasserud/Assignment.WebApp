using System.ComponentModel.DataAnnotations;

namespace Assignment.WebApp.Models.ViewModels
{
    public class SignInViewModel
    {
        [Display(Name = "E-post")]
        [EmailAddress(ErrorMessage = "E-postadressen måste vara en giltlig e-postadress")]
        [Required(ErrorMessage = "Du måste ange en E-post")]
        [StringLength(100, ErrorMessage = "E-postadressen måste vara en giltlig e-postadress", MinimumLength = 6)]
        public string Email { get; set; }

        [Display(Name = "Lösenord")]
        [Required(ErrorMessage = "Du måste ange ett lösenord")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Lösenordet måste bestå av minst 8 tecken", MinimumLength = 8)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
