using Falzoni.Presentation.Administrator.Clients.Base;
using Falzoni.Presentation.Administrator.Models.Register;
using Falzoni.Presentation.Administrator.Models.Tables.Register;

namespace Falzoni.Presentation.Administrator.Clients.Interfaces.Register
{
    public interface IUserClient : IBaseClient<UserModel, UserTableModel>
    {
    }
}
