namespace Project.Models
{
    // Models/HoSo.cs
    public class HoSo
    {
        public string MaHoSo { get; set; }
        public string TinhTrang { get; set; }
        public bool DaDuyet { get; set; }
        public DateTime NgayNop { get; set; }
        public string GhiChuXacThuc { get; set; }
        public string GhiChuXetDuyet { get; set; }
        public string IdUserXacThuc { get; set; }
        public string IdUserXetDuyet { get; set; }
        public string IdUserLuuTru { get; set; }

        // Phương thức để hiển thị icon tình trạng
        public string HienThiTinhTrang()
        {
            if (DaDuyet)
                return "Đã duyệt";
            else if (TinhTrang == "Chưa duyệt")
                return "❌";
            else
                return TinhTrang;
        }
    }
}
