using Microsoft.AspNetCore.Mvc;

namespace SurfsUpDan.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using SurfsUpDan.Data;
    using SurfsUpDan.Models;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Display surfboard details
        public IActionResult SurfboardDetails(int id)
        {
            var surfboard = _context.Surfboards.FirstOrDefault(s => s.SurfboardId == id);
            if (surfboard == null) return NotFound();

            return View(surfboard);
        }

        // Handle booking
        [HttpPost]
        public async Task<IActionResult> Book(int surfboardId, DateTime startDate, DateTime endDate)
        {
            var surfboard = _context.Surfboards.FirstOrDefault(s => s.SurfboardId == surfboardId);
            if (surfboard == null) return NotFound();

            // Calculate total price based on the number of days
            var totalDays = (endDate - startDate).Days;
            if (totalDays <= 0)
            {
                ModelState.AddModelError("", "End date must be after start date.");
                return View("SurfboardDetails", surfboard);
            }

            var totalPrice = totalDays * surfboard.PricePerDay;

            // Create the booking
            var booking = new Booking
            {
                SurfboardId = surfboardId,
                StartDate = startDate,
                EndDate = endDate,
                TotalPrice = totalPrice
            };

            // Save the booking to the database
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return RedirectToAction("Confirmation", new { bookingId = booking.BookingId });
        }

        // Show booking confirmation
        public IActionResult Confirmation(int bookingId)
        {
            var booking = _context.Bookings
                .Include(b => b.Surfboard)
                .FirstOrDefault(b => b.BookingId == bookingId);

            if (booking == null) return NotFound();

            return View(booking);
        }
    }

}
