using System.ComponentModel.DataAnnotations;

namespace WebAppChat.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Enter your email !!!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your password !!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
