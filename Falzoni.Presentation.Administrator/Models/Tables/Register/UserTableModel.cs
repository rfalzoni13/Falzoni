using Falzoni.Presentation.Administrator.Models.Base;
using Falzoni.Presentation.Administrator.Models.Tables.Base;
using System.Collections.Generic;

namespace Falzoni.Presentation.Administrator.Models.Tables.Register
{
    public class UserTableModel : TableBase
    {
        public UserTableModel() 
        {
            data = new List<UserListTableModel>();
        }

        public virtual List<UserListTableModel> data {  get; set; }
    }

    public class UserListTableModel : BaseModel
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

    }
}