using Falzoni.Presentation.Administrator.Clients.Interfaces.Base;
using Falzoni.Presentation.Administrator.Models.Register;
using Falzoni.Presentation.Administrator.Models.Tables.Register;
using System.Collections.Generic;

namespace Falzoni.Presentation.Administrator.Clients.Interfaces.Register
{
    public interface IRoleClient : IBaseClient<RoleModel, RoleTableModel>
    {
        List<string> GetAllNames();
    }
}
