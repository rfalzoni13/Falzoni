using Falzoni.Domain.Entities.Registration;
using Falzoni.Domain.Interfaces.Base;
using System;

namespace Falzoni.Domain.Interfaces.Registration
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        Customer GetWithInclude(Guid Id);
    }
}
