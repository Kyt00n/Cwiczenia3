using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Cwiczenia3.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "podaj imie")]
        [MinLength(2)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "podaj nazwisko")]
        [MinLength(2)]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Podaj Haslo")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,30}$")]
        [DataType(DataType.Password)]
        [HiddenInput]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Hasla sie nie zgadzają")]
        [DataType(DataType.Password)]
        [HiddenInput]
        public string ConfirmPassword { get; set; }
        [Phone]
        public string? NumerTelefonu { get; set; }
        [Range(10, 80, ErrorMessage = "Wiek po za dozwolonym poziomem")]
        public int? Wiek { get; set; }
        public string? Miasto { get; set; }
        public enum Miasta
        {
            Warszawa = 0,
            Łódź = 1,
            Wrocław = 2,
            Katowice = 3,
            Kraków = 4
        }
    }
    
}
