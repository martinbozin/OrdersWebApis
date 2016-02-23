using System.Data.Entity.ModelConfiguration;
using OrdersApp.Domain;

namespace OrdersApp.Data
{
    class OrderMappingConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderMappingConfiguration()
        {
            ToTable("Orders");
            HasKey(x => x.OrderId);
            Property(x => x.Price).HasColumnName("Price");
            Property(x => x.CreatedDate).HasColumnName("CreatedDate");

            HasOptional(p => p.User)
             .WithMany(b => b.UserOrders)
             .Map(m => m.MapKey("UserId"));
        }
    }
}
