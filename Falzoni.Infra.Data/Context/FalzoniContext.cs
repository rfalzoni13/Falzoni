using Falzoni.Domain.Entities.Registration;
using Falzoni.Infra.Data.Context.MySql;
using Falzoni.Infra.Data.Context.SqlServer;
using Falzoni.Infra.Data.Identity;
using Falzoni.Utils.Helpers;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;

namespace Falzoni.Infra.Data.Context
{
    public class FalzoniContext : IdentityDbContext<ApplicationUser>
    {
        #region Attributes
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        #endregion

        public FalzoniContext()
            : base("Falzoni", throwIfV1Schema: false)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public static FalzoniContext Create()
        {
            switch (ConfigurationHelper.ProviderName)
            {
                case "SqlServer":
                    return new FalzoniSqlServerContext();

                case "MySql":
                    return new FalzoniMySqlContext();

                default:
                    throw new System.Exception("Erro ao definir provider");
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Create Generic instances of EntityBaseTypeConfiguration
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !string.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
