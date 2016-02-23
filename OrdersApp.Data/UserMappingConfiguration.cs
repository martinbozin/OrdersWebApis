using System.Data.Entity.ModelConfiguration;
using OrdersApp.Domain;

namespace OrdersApp.Data
{
    public class UserMappingConfiguration : EntityTypeConfiguration<User>
    {
        public UserMappingConfiguration()
        {
            ToTable("Users");
            HasKey(x => x.UserId);
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Email).HasColumnName("Email");
        }
    }
}
