using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHoChieu.Models.ViewModels
{
    public class TaiKhoan
    {
        [Key]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string MatKhau { get; set; }
    }

    public class User
    {
        [Key]
        [StringLength(20)]
        public string UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(100)]
        public string QueQuan { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Số điện thoại")]
        public string SDT { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string ChucVu { get; set; }

        [Required]
        [StringLength(20)]
        [ForeignKey(nameof(TaiKhoan))]
        public string Username { get; set; }

        public TaiKhoan TaiKhoan { get; set; }
    }

    public class ResidentData
    {
        [Key]
        [StringLength(20)]
        public string CCCD { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(100)]
        public string NoiSinh { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NgayCap { get; set; }

        [Required]
        [StringLength(100)]
        public string NoiCap { get; set; }

        [Required]
        [StringLength(50)]
        public string DanToc { get; set; }

        [StringLength(50)]
        public string TonGiao { get; set; }

        [Required]
        [StringLength(15)]
        public string SDT { get; set; }

        [Required]
        [StringLength(100)]
        public string ttTinhThanh { get; set; }

        [Required]
        [StringLength(100)]
        public string ttQuanHuyen { get; set; }

        [Required]
        [StringLength(100)]
        public string ttPhuongXa { get; set; }

        [Required]
        [StringLength(100)]
        public string ttSoNhaDuong { get; set; }

        [Required]
        [StringLength(100)]
        public string thtTinhThanh { get; set; }

        [Required]
        [StringLength(100)]
        public string thtQuanHuyen { get; set; }

        [Required]
        [StringLength(100)]
        public string thtPhuongXa { get; set; }

        [Required]
        [StringLength(100)]
        public string thtSoNhaDuong { get; set; }

        [StringLength(100)]
        public string HoTenCha { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NgaySinhCha { get; set; }

        [StringLength(100)]
        public string HoTenMe { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NgaySinhMe { get; set; }
    }

    public class PassportData
    {
        [Key]
        [StringLength(20)]
        public string FormID { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(100)]
        public string NoiSinh { get; set; }

        [Required]
        [StringLength(20)]
        [ForeignKey(nameof(ResidentData))]
        public string CCCD { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NgayCap { get; set; }

        [Required]
        [StringLength(100)]
        public string NoiCap { get; set; }

        [Required]
        [StringLength(50)]
        public string DanToc { get; set; }

        [StringLength(50)]
        public string TonGiao { get; set; }

        [Required]
        [StringLength(15)]
        public string SDT { get; set; }

        [Required]
        [StringLength(100)]
        public string ttTinhThanh { get; set; }

        [Required]
        [StringLength(100)]
        public string ttQuanHuyen { get; set; }

        [Required]
        [StringLength(100)]
        public string ttPhuongXa { get; set; }

        [Required]
        [StringLength(100)]
        public string ttSoNhaDuong { get; set; }

        [Required]
        [StringLength(100)]
        public string thtTinhThanh { get; set; }

        [Required]
        [StringLength(100)]
        public string thtQuanHuyen { get; set; }

        [Required]
        [StringLength(100)]
        public string thtPhuongXa { get; set; }

        [Required]
        [StringLength(100)]
        public string thtSoNhaDuong { get; set; }

        [StringLength(100)]
        public string NgheNghiep { get; set; }

        [StringLength(100)]
        public string CoQuan { get; set; }

        [StringLength(100)]
        public string DiaChiCoQuan { get; set; }

        [StringLength(100)]
        public string HoTenCha { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NgaySinhCha { get; set; }

        [StringLength(100)]
        public string HoTenMe { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NgaySinhMe { get; set; }

        [Required]
        public string NoiDungDeNghi { get; set; }

        [Required]
        [StringLength(100)]
        public string NoiTiepNhanHS { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NgayNop { get; set; }

        public ResidentData ResidentData { get; set; }
    }

    public class XuLy
    {
        [Key]
        public int XuLyID { get; set; }

        [Required]
        [StringLength(20)]
        [ForeignKey(nameof(PassportData))]
        public string FormID { get; set; }

        [Required]
        [StringLength(20)]
        [ForeignKey(nameof(User))]
        public string UserID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NgayXuLy { get; set; }

        [Required]
        [StringLength(50)]
        public string TrangThai { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiXuLy { get; set; }

        public PassportData PassportData { get; set; }

        public User User { get; set; }
    }

    public class LuuTru
    {
        [Key]
        [StringLength(20)]
        public string PassportID { get; set; }

        [Required]
        [StringLength(20)]
        [ForeignKey(nameof(User))]
        public string UserID { get; set; }

        [Required]
        [StringLength(20)]
        [ForeignKey(nameof(PassportData))]
        public string FormID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NgayNop { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NgayCap { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CoGiaTriDen { get; set; }

        public User User { get; set; }

        public PassportData PassportData { get; set; }
    }
}
