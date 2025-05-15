using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLHoChieu.Data;
using QLHoChieu.Models;

namespace QLHoChieu.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResidentDataController : ControllerBase
    {
        private readonly PassportDbContext _context;

        public ResidentDataController(PassportDbContext context)
        {
            _context = context;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddResident([FromBody] ResidentData resident)
        {
            // Check if the CCCD already exists
            if (await _context.ResidentDatas.AnyAsync(r => r.CCCD == resident.CCCD))
            {
                return Conflict("Resident with this CCCD already exists.");
            }

            _context.ResidentDatas.Add(resident);
            await _context.SaveChangesAsync();

            return Ok("Resident data added successfully.");
        }
    }
}
