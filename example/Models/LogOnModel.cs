using System.ComponentModel.DataAnnotations;

namespace example.Models
{
    public class LogOnModel
    {
        [Required]
        [Display(Name = "User email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}