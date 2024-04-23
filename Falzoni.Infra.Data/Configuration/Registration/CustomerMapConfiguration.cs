using Falzoni.Domain.Entities.Registration;
using System.Data.Entity.ModelConfiguration;

namespace Falzoni.Infra.Data.Configuration.Registration
{
    public class CustomerMapConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerMapConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Name).IsRequired().HasMaxLength(1024);

            Property(c => c.DateBirth).IsRequired();

            Property(c => c.Gender).IsRequired().HasMaxLength(50);
            
            Property(c => c.PhoneNumber).IsOptional().HasMaxLength(15);
            
            Property(c => c.CellPhoneNumber).IsRequired().HasMaxLength(15);

            Property(c => c.Document).IsRequired().HasMaxLength(20);

            Property(c => c.Email).IsRequired().HasMaxLength(128);

            Property(c => c.Created).IsRequired();

            Property(c => c.Modified).IsOptional();


            HasMany(c => c.Addresses).WithRequired(a => a.Customer).HasForeignKey(a => a.CustomerId).WillCascadeOnDelete();
        }
    }
}
