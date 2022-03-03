using Microsoft.EntityFrameworkCore;

namespace rest_api.Models
{
    public class EcommerceDBContext : DbContext
    {
        public EcommerceDBContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
