using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLHoChieu.Data;
using QLHoChieu.Models;

namespace QLHoChieu.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PassportDataController : Controller
    {
        private readonly PassportDbContext _context;
        public PassportDataController(PassportDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] PassportData data)
        {
            if (data == null || string.IsNullOrWhiteSpace(data.FormID))
                return BadRequest("Invalid data.");

            // Check for duplicate FormID
            if (await _context.PassportDatas.AnyAsync(p => p.FormID == data.FormID))
                return Conflict("FormID already exists.");

            _context.PassportDatas.Add(data);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Passport registered successfully." });
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
