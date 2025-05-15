using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLHoChieu.Models
{
    [Table("LuuTru")]
    public class LuuTru
    {
        [Key]
        [StringLength(20)]
        public string PassportID { get; set; } = null!;  // Primary key

        [Required]
        [StringLength(20)]
        public string UserID { get; set; } = null!;  // FK to User

        [Required]
        [StringLength(20)]
        public string FormID { get; set; } = null!;  // FK to PassportData, unique

        [Required]
        public DateTime NgayNop { get; set; }

        [Required]
        public DateTime NgayCap { get; set; }

        [Required]
        public DateTime CoGiaTriDen { get; set; }

        // Navigation properties

        [ForeignKey(nameof(UserID))]
        public User User { get; set; } = null!;

        [ForeignKey(nameof(FormID))]
        public PassportData PassportData { get; set; } = null!;
    }
}
