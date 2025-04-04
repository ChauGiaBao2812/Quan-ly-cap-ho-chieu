using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
