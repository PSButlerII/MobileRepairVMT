using MobileRepairMT.Configuration;
using MobileRepairMT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MobileRepairMT.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        // Creating a Joint Table for our Shopping Cart
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<CustomerLti> CustomerLtis { get; set; }
        public DbSet<EmployeeLti> EmployeeLtis { get; set; }
        public DbSet<ProductShoppingCart> ProductShoppingCarts { get; set; }
        public DbSet<ServiceShoppingCart> ServiceShoppingCarts { get; set; }
        public DbSet<ShopService> ShopServices { get; set; }
      
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RolesConfiguration());
        }

    }
}
