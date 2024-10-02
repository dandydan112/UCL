using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Optimistic_locking_18_09_2024.Data;
using Optimistic_locking_18_09_2024.Models;
using System.Diagnostics;

namespace Optimistic_locking_18_09_2024.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        AppDbContext _context;
        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            // Fetch a product with Id = 1 from the database
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == 1);

            // Check if the product exists
            if (product == null)
            {
                return NotFound(); // Handle case when the product is not found
            }

            // Pass the product to the view
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
