using backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class StoreContext(DbContextOptions options) : DbContext(options)
    {
        public required DbSet<Product> Products { get; set; }
        public required DbSet<Cart> Carts { get; set; }
    }
}
