
using Microsoft.EntityFrameworkCore;
using Models;

namespace DatabaseContext.DbContext
{
    public class EcommerceDatabaseContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(local);Database=EcommerceDB; Integrated Security=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
