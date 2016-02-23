using System.Data.Entity;
using OrdersApp.Domain;

namespace OrdersApp.Data
{
    public class OrdersAppDbContext : DbContext
    {
        public OrdersAppDbContext() : base("OrdersAppDbContext")
        {
        }

        public OrdersAppDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Order> Orders { get; set; }
      
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMappingConfiguration());
            modelBuilder.Configurations.Add(new OrderMappingConfiguration());
        }
    }
}