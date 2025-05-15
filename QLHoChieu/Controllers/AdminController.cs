using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using QLHoChieu.Data;
using QLHoChieu.Models;
using QLHoChieu.Models.ViewModels;

namespace QLHoChieu.Controllers
{
    public class AdminController : Controller
    {
        private readonly PassportDbContext _context;

        public AdminController(PassportDbContext context)
        {
            _context = context;
        }

        // GET: TaiKhoan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TaiKhoan/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaiKhoanVM model)
        {
            if (ModelState.IsValid)
            {
                // Hash password
                byte[] hashedPassword = HashPassword(model.MatKhau);

                // Map ViewModel to Entity
                var entity = new TaiKhoan
                {
                    Username = model.Username,
                    MatKhau = hashedPassword
                };

                _context.TaiKhoans.Add(entity);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index)); // or wherever you want to redirect
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
