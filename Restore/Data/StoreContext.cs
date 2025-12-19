using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restore.Entities;

namespace Restore.Data
{
    public class StoreContext(DbContextOptions options) : IdentityDbContext<User>(options)
    {
        public required DbSet<Product> Products { get; set; }
        public required DbSet<Basket> Baskets { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole { Id = "C081233B-4D84-4238-BEC4-604F893DF9EB", Name = "Member", NormalizedName = "MEMBER" },
                    new IdentityRole { Id = "E5EF418E-D5A4-4B05-A047-BA5C14309225", Name = "Admin", NormalizedName = "ADMIN" }
                );

        }
    }
}
