using Microsoft.AspNetCore.Mvc;
using Project.Models;
namespace Project.Controllers
{
    public class ListUserHandleController : Controller
    {
        public ActionResult ListUserHandle()
        {
            var danhSachHoSo = new List<UserHandle>
        {
            new UserHandle { ID_User = "USER001", MaHoSo = "HS001", IdHoSo = "ID001", ThoiGianDuyet = new DateTime(2025, 3, 12) },
            new UserHandle { ID_User = "USER002", MaHoSo = "HS002", IdHoSo = "ID002", ThoiGianDuyet = new DateTime(2025, 3, 11) }
        };

            return View(danhSachHoSo);
        }
    }
}
