using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Project.Models;
namespace Project.Controllers
{
    public class PersonInfoController : Controller
    {
        public ActionResult PersonInfo()
        {
            var model = new PersonInfo
            {
                HoTen = "Nguyễn Văn A",
                NgaySinh = new DateTime(1990, 1, 1),
                ChucVu = "Nhân viên",
                QueQuan = "Hà Nội",
                DiaChi = "123 Đường ABC, Quận 1, TP.HCM",
                SoDienThoai = "0901234567",
                Email = "nguyenvana@example.com"
            };
            return View(model);
        }
    }
}
