using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using QLHoChieu.Data;
using QLHoChieu.Models;
using QLHoChieu.Models.ViewModels;
using QLHoChieu.Helpers;

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
        public async Task<IActionResult> Create(RegisterAccountVM model)
        {
            if (ModelState.IsValid)
            {
                var hashedPassword = HashPassword(model.Password);

                var newAccount = new TaiKhoan
                {
                    Username = model.Username,
                    MatKhau = hashedPassword
                };

                var newUser = new User
                {
                    UserID = Guid.NewGuid().ToString().Substring(0, 20),
                    Username = model.Username,
                    HoTen = AesHelper.Encrypt(model.HoTen),
                    GioiTinh = model.GioiTinh,
                    NgaySinh = model.NgaySinh,
                    QueQuan = model.QueQuan,
                    SDT = AesHelper.Encrypt(model.SDT),
                    Email = AesHelper.Encrypt(model.Email),
                    ChucVu = model.ChucVu
                };

                _context.TaiKhoans.Add(newAccount);
                _context.Users.Add(newUser);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index"); // or somewhere else
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
