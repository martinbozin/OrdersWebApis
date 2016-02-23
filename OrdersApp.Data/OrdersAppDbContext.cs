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

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Orders { get; set; }
      
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMappingConfiguration());
            modelBuilder.Configurations.Add(new OrderMappingConfiguration());
        }
    }
}