using Falzoni.Domain.Entities.Register;
using Falzoni.Domain.Interfaces.Register;
using Falzoni.Infra.Data.Context;
using Falzoni.Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Falzoni.Infra.Data.Repositories.Register
{
    public class CustomerAddressRepository : BaseRepository<CustomerAddress>, ICustomerAddressRepository
    {
        public void RemoveRange(ICollection<Guid> ids)
        {
            using (var context = FalzoniContext.Create())
            {
                ICollection<CustomerAddress> enderecos = context.CustomerAddress.Where(x => !ids.Contains(x.Id)).ToList();
                if (enderecos.Any())
                {
                    context.CustomerAddress.RemoveRange(enderecos);
                    context.SaveChanges();
                }
            }
        }
    }
}
