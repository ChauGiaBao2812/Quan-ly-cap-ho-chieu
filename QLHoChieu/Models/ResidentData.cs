using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLHoChieu.Models
{
    [Table("ResidentData")]
    public class ResidentData
    {
        [Key]
        [MaxLength(256)]
        public byte[] CCCD { get; set; } = null!; // AES encrypted primary key

        [Required]
        [MaxLength(256)]
        public byte[] HoTen { get; set; } = null!; // AES encrypted full name

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; } = null!; // plain text gender

        [Required]
        public DateTime NgaySinh { get; set; } // DOB plain

        [Required]
        [MaxLength(256)]
        public byte[] NoiSinh { get; set; } = null!; // AES encrypted place of birth

        [Required]
        public DateTime NgayCap { get; set; } // Issue date plain

        [Required]
        [MaxLength(256)]
        public byte[] NoiCap { get; set; } = null!; // AES encrypted place of issue

        [Required]
        [StringLength(50)]
        public string DanToc { get; set; } = null!; // ethnicity, plain

        [StringLength(50)]
        public string? TonGiao { get; set; } // religion, nullable plain

        [Required]
        [MaxLength(128)]
        [Column("SĐT")]
        public byte[] SDT { get; set; } = null!; // AES encrypted phone

        // Địa chỉ thường trú (permanent address), AES encrypted parts
        [Required]
        [MaxLength(256)]
        public byte[] ttTinhThanh { get; set; } = null!;

        [Required]
        [MaxLength(256)]
        public byte[] ttQuanHuyen { get; set; } = null!;

        [Required]
        [MaxLength(256)]
        public byte[] ttPhuongXa { get; set; } = null!;

        [Required]
        [MaxLength(256)]
        public byte[] ttSoNhaDuong { get; set; } = null!;

        // Địa chỉ tạm trú (temporary address), AES encrypted parts
        [Required]
        [MaxLength(256)]
        public byte[] thtTinhThanh { get; set; } = null!;

        [Required]
        [MaxLength(256)]
        public byte[] thtQuanHuyen { get; set; } = null!;

        [Required]
        [MaxLength(256)]
        public byte[] thtPhuongXa { get; set; } = null!;

        [Required]
        [MaxLength(256)]
        public byte[] thtSoNhaDuong { get; set; } = null!;

        // Parents' info, optional AES encrypted names, plain dates
        [MaxLength(256)]
        public byte[]? HoTenCha { get; set; }

        public DateTime? NgaySinhCha { get; set; }

        [MaxLength(256)]
        public byte[]? HoTenMe { get; set; }

        public DateTime? NgaySinhMe { get; set; }
    }
}
