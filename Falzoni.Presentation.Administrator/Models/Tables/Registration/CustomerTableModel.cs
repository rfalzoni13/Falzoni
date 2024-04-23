﻿using Falzoni.Presentation.Administrator.Models.Base;
using Falzoni.Presentation.Administrator.Models.Tables.Base;
using System.Collections.Generic;

namespace Falzoni.Presentation.Administrator.Models.Tables.Registration
{
    public class CustomerTableModel : TableBase
    {
        public CustomerTableModel()
        {
            data = new List<CustomerListTableModel>();
        }

        public virtual List<CustomerListTableModel> data { get; set; }
    }

    public class CustomerListTableModel : BaseModel
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string Document { get; set; }

    }
}