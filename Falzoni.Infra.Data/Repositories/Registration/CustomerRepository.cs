using Falzoni.Domain.Entities.Registration;
using Falzoni.Domain.Interfaces.Registration;
using Falzoni.Infra.Data.Context;
using Falzoni.Infra.Data.Repositories.Base;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Falzoni.Infra.Data.Repositories.Registration
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public Customer GetWithInclude(Guid Id)
        {
            using (var context = FalzoniContext.Create())
            {
                return context.Customer
                .Include(x => x.Addresses)
                .FirstOrDefault(x => x.Id == Id);
            }
        }

        public override void Update(Customer obj)
        {
            using (var context = FalzoniContext.Create())
            {
                foreach (var endereco in obj.Addresses)
                {
                    context.CustomerAddress.AddOrUpdate(endereco);
                }

                context.Customer.AddOrUpdate(obj);
                context.SaveChanges();
            }
        }

        public override void Delete(Guid Id)
        {
            using (var context = FalzoniContext.Create())
            {
                var obj = context.Customer.Include(x => x.Addresses).FirstOrDefault(x => x.Id == Id);
                if (obj != null)
                {
                    context.Customer.Remove(obj);
                    context.SaveChanges();
                }

            }
        }
    }
}
