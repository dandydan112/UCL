using Microsoft.EntityFrameworkCore;


namespace API_26_09_204.Models
{

    public class YourDbContext : DbContext
    {
        public YourDbContext(DbContextOptions<YourDbContext> options)
            : base(options)
        {

        }

        // Define your DbSets (tables)
        public DbSet<Shirt> Shirts { get; set; }
    }

}
