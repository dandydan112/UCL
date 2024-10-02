namespace SurfsUpDan.Data
{
    using Microsoft.EntityFrameworkCore;
    using SurfsUpDan.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Surfboard> Surfboards { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Surfboard>().HasData(
                new Surfboard
                {
                    SurfboardId = 1,
                    Name = "Classic Longboard",
                    Length = 9.0f,
                    Width = 22.5f,
                    Thickness = 3.0f,
                    Volume = 72.0f,
                    Type = "Longboard",
                    PricePerDay = 50.0m,
                    Equipment = "Leash, Fins"
                }
            );
        }

    }


}
