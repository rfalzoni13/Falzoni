using Falzoni.Presentation.Administrator.Clients.Interfaces.Base;
using Falzoni.Presentation.Administrator.Models.Configuration;
using Falzoni.Presentation.Administrator.Models.Tables.Configuration;

namespace Falzoni.Presentation.Administrator.Clients.Interfaces.Configuration
{
    public interface IUserClient : IBaseClient<UserModel, UserTableModel>
    {
    }
}
