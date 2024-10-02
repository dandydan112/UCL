using Microsoft.AspNetCore.Mvc;
using Optimistic_locking_18_09_2024.Data;
using Optimistic_locking_18_09_2024.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Optimistic_locking_18_09_2024.Controllers
{


    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        // Constructor Injection of AppDbContext
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // This method will add a new product to the database
        public async Task<IActionResult> AddProduct()
        {
            var product = new Product
            {
                Name = "New Product",
                Price = 19.99M
            };

            // Adding the product to the database context
            _context.Products.Add(product);

            // Saving the changes to the database
            await _context.SaveChangesAsync();

            // Return a response indicating success
            return Ok("Product added successfully!");
        }
    }
}

