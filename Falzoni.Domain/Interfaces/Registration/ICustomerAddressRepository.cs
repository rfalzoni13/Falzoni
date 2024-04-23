using Falzoni.Domain.Entities.Registration;
using Falzoni.Domain.Interfaces.Base;
using System.Collections.Generic;
using System;

namespace Falzoni.Domain.Interfaces.Registration
{
    public interface ICustomerAddressRepository : IBaseRepository<CustomerAddress>
    {
        void RemoveRange(ICollection<Guid> ids);
    }
}
