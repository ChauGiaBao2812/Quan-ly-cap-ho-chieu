using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Project.Models;

namespace Project.Controllers
{
    public class MonitorController : Controller
    {
        public IActionResult ListProfile()
        {
            var danhSachHoSo = new List<HoSo>
            {
                new HoSo { MaHoSo = "HS01", TinhTrang = "Lưu trữ", DaDuyet = true, NgayNop = new DateTime(2025, 3, 12) },
                new HoSo { MaHoSo = "HS02", TinhTrang = "Xác thực", DaDuyet = true, NgayNop = new DateTime(2025, 3, 11) },
                new HoSo { MaHoSo = "HS03", TinhTrang = "Xét duyệt", DaDuyet = false, NgayNop = new DateTime(2025, 3, 10) },
                new HoSo { MaHoSo = "HS04", TinhTrang = "Lưu trữ", DaDuyet = false, NgayNop = new DateTime(2025, 3, 9) }
            };
            return View(danhSachHoSo);
        }

        public IActionResult Detail(string id)
        {
            // Dữ liệu mẫu - nên thay bằng lấy từ database
            var hoSo = new HoSo
            {
                MaHoSo = id,
                TinhTrang = "Xác thực",
                DaDuyet = true,
                NgayNop = new DateTime(2025, 3, 12),
                GhiChuXacThuc = "Đã xác thực thông tin người nộp",
                GhiChuXetDuyet = "Đủ điều kiện xét duyệt",
                IdUserXacThuc = "user_XT_001",
                IdUserXetDuyet = "user_XD_002",
                IdUserLuuTru = "user_LT_003"
            };

            return View(hoSo);
        }
    }
}