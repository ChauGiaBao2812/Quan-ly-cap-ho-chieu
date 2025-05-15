using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHoChieu.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [StringLength(20)]
        public string UserID { get; set; } = null!;

        [Required]
        [MaxLength(256)]
        public byte[] HoTen { get; set; } = null!;   // AES Encrypted Full Name

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; } = null!;  // Plain text

        [Required]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(100)]
        public string QueQuan { get; set; } = null!;  // Plain text

        [Required]
        [MaxLength(128)]
        [Column("SĐT")]
        public byte[] SDT { get; set; } = null!;     // AES Encrypted Phone

        [Required]
        [MaxLength(256)]
        public byte[] Email { get; set; } = null!;    // AES Encrypted Email

        [Required]
        [StringLength(50)]
        public string ChucVu { get; set; } = null!;   // Plain text

        [Required]
        [StringLength(20)]
        public string Username { get; set; } = null!; // FK

        [ForeignKey("Username")]
        public TaiKhoan TaiKhoan { get; set; } = null!;
    }

}
