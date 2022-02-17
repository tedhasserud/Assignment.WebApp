using System.ComponentModel.DataAnnotations;

namespace Assignment.WebApp.Models.ViewModels
{
    public class SignUpViewModel
    {
        [Display(Name = "Förnamn")]
        [Required(ErrorMessage = "Du måste ange ett förnamn")]
        [StringLength(100, ErrorMessage = "Förnamnet måste bestå av minst 2 tecken", MinimumLength = 2)]
        public string FirstName { get; set; }
        
        [Display(Name = "Efternamn")]
        [Required(ErrorMessage = "Du måste ange ett Efternamn")]
        [StringLength(100, ErrorMessage = "Efternamnet måste bestå av minst 2 tecken", MinimumLength = 2)]
        public string LastName { get; set; }
        
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

        [Display(Name = "Bekräfta lösenord")]
        [Required(ErrorMessage = "Du måste bekräfta lösenordet")]
        [Compare(nameof(Password), ErrorMessage = "Lösenorden matchar inte")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Gatuadress")]
        [Required(ErrorMessage = "Du måste ange en gatuadress")]
        [StringLength(100, ErrorMessage = "Gatuadressen måste bestå av minst 2 tecken", MinimumLength = 2)]
        public string StreetName { get; set; }

        [Display(Name = "Postnummer")]
        [Required(ErrorMessage = "Du måste ange ett postnummer")]
        [StringLength(100, ErrorMessage = "Postnumret måste bestå av 5 siffror", MinimumLength = 5)]
        public string PostalCode { get; set; }

        [Display(Name = "Ort")]
        [Required(ErrorMessage = "Du måste ange en ort")]
        [StringLength(100, ErrorMessage = "Ortnamnet måste bestå av minst 2 tecken", MinimumLength = 2)]
        public string City { get; set; }


    }
}
