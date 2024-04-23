using Falzoni.Presentation.Administrator.Models.Base;
using Falzoni.Presentation.Administrator.Models.Tables.Base;
using System.Collections.Generic;

namespace Falzoni.Presentation.Administrator.Models.Tables.Register
{
    public class RoleTableModel : TableBase
    {
        public RoleTableModel() 
        {
            data = new List<RoleListTableModel>();
        }

        public virtual List<RoleListTableModel> data { get; set; }
    }

    public class RoleListTableModel : BaseModel
    {
        public string Name { get; set; }
    }
}