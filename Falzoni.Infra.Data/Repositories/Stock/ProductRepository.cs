using Falzoni.Domain.Entities.Stock;
using Falzoni.Domain.Interfaces.Stock;
using Falzoni.Infra.Data.Repositories.Base;

namespace Falzoni.Infra.Data.Repositories.Stock
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
    }
}
