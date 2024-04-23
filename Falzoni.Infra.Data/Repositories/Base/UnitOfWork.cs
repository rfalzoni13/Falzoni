using Falzoni.Domain.Interfaces.Base;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace Falzoni.Infra.Data.Repositories.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public DbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.Database.BeginTransaction().Commit();
        }

        public void RollBack()
        {
            _context.Database.BeginTransaction().Rollback();
        }

        public void Dispose()
        {
            _context.Database.BeginTransaction().Dispose();
        }
    }
}
