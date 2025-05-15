using System.ComponentModel.DataAnnotations;

namespace QLHoChieu.Models.ViewModels
{
    public class RegisterAccountVM
    {
        // TaiKhoan
        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        // User
        [Required]
        public string HoTen { get; set; }

        [Required]
        public string GioiTinh { get; set; }

        [Required]
        public DateTime NgaySinh { get; set; }

        [Required]
        public string QueQuan { get; set; }

        [Required]
        public string SDT { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string ChucVu { get; set; }
    }
}