using Microsoft.EntityFrameworkCore;
using Optimistic_locking_18_09_2024.Models;

namespace Optimistic_locking_18_09_2024.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // This will create a table for the Product entity
        public DbSet<Product> Products { get; set; }

        // Optional: Seeding initial data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Sample Product", Price = 9.99M }
            );
        }

    }

}
