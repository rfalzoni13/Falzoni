using Falzoni.Domain.Entities.Register;
using Falzoni.Domain.Interfaces.Base;
using System.Collections.Generic;
using System;

namespace Falzoni.Domain.Interfaces.Register
{
    public interface ICustomerAddressRepository : IBaseRepository<CustomerAddress>
    {
        void RemoveRange(ICollection<Guid> ids);
    }
}
