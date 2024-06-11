using Falzoni.Presentation.Administrator.Clients.Interfaces.Base;
using Falzoni.Presentation.Administrator.Models.Configuration;
using Falzoni.Presentation.Administrator.Models.Tables.Configuration;
using System.Collections.Generic;

namespace Falzoni.Presentation.Administrator.Clients.Interfaces.Configuration
{
    public interface IRoleClient : IBaseClient<RoleModel, RoleTableModel>
    {
        List<string> GetAllNames();
    }
}
