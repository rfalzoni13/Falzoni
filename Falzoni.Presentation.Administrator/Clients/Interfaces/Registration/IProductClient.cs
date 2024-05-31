using Falzoni.Presentation.Administrator.Clients.Interfaces.Base;
using Falzoni.Presentation.Administrator.Models.Registration;
using Falzoni.Presentation.Administrator.Models.Tables.Registration;

namespace Falzoni.Presentation.Administrator.Clients.Interfaces.Registration
{
    public interface IProductClient : IBaseClient<ProductModel, ProductTableModel>
    {
    }
}