using System.Data.Entity;
using OrdersApp.Domain;

namespace OrdersApp.Data
{
    public class EmploiaDbContext : DbContext
    {
        public EmploiaDbContext() : base("OrdersAppDbContext")
        {
        }

        public EmploiaDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Order> Orders { get; set; }
      
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
 
        }
    }
}