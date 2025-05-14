using System.ComponentModel.DataAnnotations;

namespace QLHoChieu.Models
{
    public class LoginForm
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}