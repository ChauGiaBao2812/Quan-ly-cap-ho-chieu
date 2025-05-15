using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLHoChieu.Models
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        [Key]
        [StringLength(20)]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(64)]
        public byte[] MatKhau { get; set; } = null!;
    }

}
