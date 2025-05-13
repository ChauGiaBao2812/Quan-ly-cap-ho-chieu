using Microsoft.AspNetCore.Mvc;
using Project.Models;
namespace Project.Controllers
{
    public class ListUserController : Controller
    {
        public IActionResult ListUser()
        {
            var danhSachUser = new List<UserModel>
        {
            new UserModel { ID_User = "USER001", IdHoSo = "ID001", ThoiGianDuyet = new DateTime(2025, 3, 12) },
            new UserModel { ID_User = "USER002", IdHoSo = "ID002", ThoiGianDuyet = new DateTime(2025, 3, 11) }
        };

            return View(danhSachUser);
        }
    }
}
