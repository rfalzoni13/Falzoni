using Falzoni.Domain.Entities.Register;
using Falzoni.Domain.Interfaces.Base;
using System;

namespace Falzoni.Domain.Interfaces.Register
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        Customer GetWithInclude(Guid Id);
    }
}
