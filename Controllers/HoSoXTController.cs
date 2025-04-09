using DeTai.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
public class HoSoXTController : Controller
{
    public ActionResult HoSoXT()
    {
        var hoSoList = new List<HoSoXT>
        {
            new HoSoXT { MaHoSo = "HS01", TinhTrang = "Chưa xác thực", NgayNop = DateTime.Parse("2025-03-12") },
            new HoSoXT { MaHoSo = "HS02", TinhTrang = "Đã xác thực", NgayNop = DateTime.Parse("2025-03-11") }
        };
        return View(hoSoList);
    }
}