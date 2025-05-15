using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLHoChieu.Data;
using QLHoChieu.Models.ViewModels;

namespace QLHoChieu.Controllers
{
    public class FormController : Controller
    {
        private readonly PassportDbContext _context;
        public FormController(PassportDbContext context)
        {
            _context = context;
        }
        public IActionResult Form()
        {
            return View();
        }

        public IActionResult LoginForm()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginForm(TaiKhoanVM model)
        {
            if (ModelState.IsValid)
            {
                var hashedPassword = HashPassword(model.MatKhau);

                var account = _context.TaiKhoans
                    .FirstOrDefault(u => u.Username == model.Username && u.MatKhau.SequenceEqual(hashedPassword));

                if (account != null)
                {
                    var user = _context.Users.FirstOrDefault(u => u.Username == account.Username);

                    if (user != null)
                    {
                        // TODO: Add sign-in logic later (claims, cookies, etc.)

                        // Redirect based on role
                        if (user.ChucVu == "XuLy")
                            return RedirectToAction("Create", "Admin");

                        return RedirectToAction("Index", "Home");
                    }
                }

                ModelState.AddModelError(string.Empty, "Invalid username or password.");
            }

            return View(model);
        }

        private byte[] HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
}
