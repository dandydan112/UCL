using API_26_09_204.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_26_09_204.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        private readonly YourDbContext _context;

        public ShirtsController(YourDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var shirts = await _context.Shirts.ToListAsync();
            return Ok(shirts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetShirt(int id)
        {
            var shirt = await _context.Shirts.FindAsync(id);
            if (shirt == null)
            {
                return NotFound();
            }
            return Ok(shirt);
        }

        [HttpPost]
        public async Task<IActionResult> PostShirt(Shirt shirt)
        {
            _context.Shirts.Add(shirt);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetShirt), new { id = shirt.Id }, shirt);
        }
    }

}
