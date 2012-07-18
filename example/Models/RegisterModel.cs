using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace example.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your surname")]
        public string UserSurname { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please choose your gender")]
        public bool Gender { get; set; }

        [Required(ErrorMessage = "Please write the date of your birth")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Please choose your marital status")]
        public bool? MaritalStatus { get; set; }

        public string ListOfInterests { get; set; }
    }
}