using Microsoft.EntityFrameworkCore;
using Restore.Entities;

namespace Restore.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
        public required DbSet<Product> Products { get; set; }
    }
}
