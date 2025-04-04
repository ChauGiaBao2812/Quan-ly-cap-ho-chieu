using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class LoginForm
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}