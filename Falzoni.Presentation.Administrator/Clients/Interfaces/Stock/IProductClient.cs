using Falzoni.Presentation.Administrator.Clients.Interfaces.Base;
using Falzoni.Presentation.Administrator.Models.Stock;
using Falzoni.Presentation.Administrator.Models.Tables.Stock;

namespace Falzoni.Presentation.Administrator.Clients.Interfaces.Stock
{
    public interface IProductClient : IBaseClient<ProductModel, ProductTableModel>
    {
    }
}