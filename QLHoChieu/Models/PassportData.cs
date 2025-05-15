using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLHoChieu.Models
{
    [Table("PassportData")]
    public class PassportData
    {
        [Key]
        [StringLength(20)]
        public string FormID { get; set; } = null!;  // Primary key, plain string

        [Required]
        [MaxLength(256)]
        public byte[] HoTen { get; set; } = null!;  // AES encrypted full name

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; } = null!;  // Plain text gender

        [Required]
        public DateTime NgaySinh { get; set; }  // Plain DOB

        [Required]
        [MaxLength(256)]
        public byte[] NoiSinh { get; set; } = null!;  // AES encrypted place of birth

        [Required]
        [MaxLength(256)]
        [ForeignKey(nameof(ResidentData))]
        public byte[] CCCD { get; set; } = null!;  // AES encrypted CCCD, FK to ResidentData

        [Required]
        public DateTime NgayCap { get; set; }  // Plain date of issue

        [Required]
        [MaxLength(256)]
        public byte[] NoiCap { get; set; } = null!;  // AES encrypted place of issue

        [Required]
        [StringLength(50)]
        public string DanToc { get; set; } = null!;  // Ethnicity plain

        [StringLength(50)]
        public string? TonGiao { get; set; }  // Religion nullable plain

        [Required]
        [MaxLength(128)]
        [Column("SĐT")]
        public byte[] SDT { get; set; } = null!;  // AES encrypted phone

        // Permanent address - AES encrypted
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

        // Temporary address - AES encrypted
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

        // Optional encrypted fields
        [MaxLength(256)]
        public byte[]? NgheNghiep { get; set; }

        [MaxLength(256)]
        public byte[]? CoQuan { get; set; }

        [MaxLength(256)]
        public byte[]? DiaChiCoQuan { get; set; }

        [MaxLength(256)]
        public byte[]? HoTenCha { get; set; }

        public DateTime? NgaySinhCha { get; set; }

        [MaxLength(256)]
        public byte[]? HoTenMe { get; set; }

        public DateTime? NgaySinhMe { get; set; }

        // Plain text fields
        [Required]
        public string NoiDungDeNghi { get; set; } = null!;  // NVARCHAR(MAX)

        [Required]
        [StringLength(100)]
        public string NoiTiepNhanHS { get; set; } = null!;

        [Required]
        public DateTime NgayNop { get; set; }

        // Navigation property to ResidentData
        public ResidentData ResidentData { get; set; } = null!;
    }
}
