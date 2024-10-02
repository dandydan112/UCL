using System.ComponentModel.DataAnnotations;

namespace Optimistic_locking_18_09_2024.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // A price column in the database
        public decimal Price { get; set; }

        // Optimistic concurrency control field
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
