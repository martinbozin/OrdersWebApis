using System.Data.Entity.ModelConfiguration;
using OrdersApp.Domain;

namespace OrdersApp.Data
{
    public class CustomerMappingConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerMappingConfiguration()
        {
            ToTable("Customers");
            HasKey(x => x.CustomerId);
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Email).HasColumnName("Email");
        }
    }
}
