using Falzoni.Domain.Entities.Base;
using System;

namespace Falzoni.Domain.Entities.Registration
{
    public class CustomerAddress : BaseEntity
    {
        public Guid CustomerId { get; set; }

        public string PostalCode { get; set; }

        public string AddressName { get; set; }

        public int Number { get; set; }

        public string Complement { get; set; }
        
        public string Neighborhood { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }


        public virtual Customer Customer { get; set; }
    }
}
