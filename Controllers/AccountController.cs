using Microsoft.AspNetCore.Mvc;

namespace DeTai.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}