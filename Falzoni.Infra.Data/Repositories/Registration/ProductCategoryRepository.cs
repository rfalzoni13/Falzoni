using Falzoni.Domain.Entities.Registration;
using Falzoni.Domain.Interfaces.Registration;
using Falzoni.Infra.Data.Repositories.Base;

namespace Falzoni.Infra.Data.Repositories.Registration
{
    public class ProductCategoryRepository : BaseRepository<ProductCategory>, IProductCategoryRepository
    {
    }
}
