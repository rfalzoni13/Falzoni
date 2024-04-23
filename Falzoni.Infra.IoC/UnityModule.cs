using Falzoni.Application.ServiceApplication.Identity;
using Falzoni.Application.ServiceApplication.Register;
using Falzoni.Application.ServiceApplication.Registration;
using Falzoni.Domain.Interfaces.Base;
using Falzoni.Domain.Interfaces.Registration;
using Falzoni.Infra.Data.Context.MySql;
using Falzoni.Infra.Data.Context.SqlServer;
using Falzoni.Infra.Data.Repositories.Base;
using Falzoni.Infra.Data.Repositories.Registration;
using Falzoni.Service.Registration;
using Falzoni.Utils.Helpers;
using System.Data.Entity;
using Unity;

namespace Falzoni.Infra.IoC
{
    public class UnityModule
    {
        public static UnityContainer LoadModules()
        {
            var container = new UnityContainer();

            #region Repositories
            container.RegisterType(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<ICustomerAddressRepository, CustomerAddressRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductCategoryRepository, ProductCategoryRepository>();
            #endregion

            #region Services
            container.RegisterType<CustomerService>();
            container.RegisterType<ProductService>();
            #endregion

            #region Application
            container.RegisterType<RoleServiceApplication>();
            container.RegisterType<AccountServiceApplication>();
            container.RegisterType<IdentityUtilityServiceApplication>();
            container.RegisterType<UserServiceApplication>();

            container.RegisterType<CustomerServiceApplication>();
            container.RegisterType<ProductServiceApplication>();
            #endregion

            //Complements
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            //Context
            switch (ConfigurationHelper.ProviderName)
            {
                case "SqlServer":
                    container.RegisterType<DbContext, FalzoniSqlServerContext>();
                    break;

                case "MySql":
                    container.RegisterType<DbContext, FalzoniMySqlContext>();
                    break;
            }

            return container;
        }
    }
}
