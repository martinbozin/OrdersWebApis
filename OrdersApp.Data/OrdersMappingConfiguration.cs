using System.Data.Entity.ModelConfiguration;
using OrdersApp.Domain;

namespace OrdersApp.Data
{
    class OrdersMappingConfiguration : EntityTypeConfiguration<Order>
    {
        public OrdersMappingConfiguration()
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
