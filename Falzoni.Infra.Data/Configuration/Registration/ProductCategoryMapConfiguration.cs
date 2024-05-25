using Falzoni.Domain.Entities.Registration;
using System.Data.Entity.ModelConfiguration;

namespace Falzoni.Infra.Data.Configuration.Registration
{
    public class ProductCategoryMapConfiguration : EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryMapConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Name).IsRequired().HasMaxLength(512);

            Property(p => p.Created).IsRequired();

            Property(p => p.Modified).IsOptional();
        }
    }
}
