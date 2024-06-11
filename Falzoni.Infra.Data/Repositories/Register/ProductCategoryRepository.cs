using Falzoni.Domain.Entities.Register;
using Falzoni.Domain.Interfaces.Register;
using Falzoni.Infra.Data.Repositories.Base;

namespace Falzoni.Infra.Data.Repositories.Register
{
    public class ProductCategoryRepository : BaseRepository<ProductCategory>, IProductCategoryRepository
    {
    }
}
