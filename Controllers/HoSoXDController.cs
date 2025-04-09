using DeTai.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeTai.Controllers
{
    public class HoSoXDController : Controller
    {
        public IActionResult HoSoXD()
        {
            var hoSo = new List<HoSoXD>
        {
            new HoSoXD { MaHoSo = "HS01", TinhTrang = "Chưa xét duyệt", NgayNop = DateTime.Parse("2025-03-12") },
            new HoSoXD { MaHoSo = "HS02", TinhTrang = "Đã xét duyệt", NgayNop = DateTime.Parse("2025-03-11") }
        };
            return View(hoSo);
        }
    }
}
