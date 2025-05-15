using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Project.Models;
using DeTai.Models;
using Microsoft.Extensions.Hosting;

namespace Project.Controllers
{
    public class HoSoController : Controller
    {
        public IActionResult HoSoXT()
        {
            var danhSachHoSo = new List<HoSo>
            {
                new HoSo { MaHoSo = "HS01", TinhTrang = "Chưa xác thực", NgayNop = DateTime.Parse("2025-03-12") },
                new HoSo { MaHoSo = "HS02", TinhTrang = "Đã xác thực", NgayNop = DateTime.Parse("2025-03-11") }
            };
            return View(danhSachHoSo);
        }
        public IActionResult HoSoXD()
        {
            var danhSachHoSo = new List<HoSo>
            {
                new HoSo { MaHoSo = "HS01", TinhTrang = "Chưa xét duyệt", NgayNop = DateTime.Parse("2025-03-12") },
                new HoSo { MaHoSo = "HS02", TinhTrang = "Đã xét duyệt", NgayNop = DateTime.Parse("2025-03-11") }
            };
            return View(danhSachHoSo);
        }
    }
}
