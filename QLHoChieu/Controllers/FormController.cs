using Microsoft.AspNetCore.Mvc;

namespace QLHoChieu.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult LoginForm()
        {
            return View();
        }
    }
}
