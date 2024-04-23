using System;
using System.Data.Entity;

namespace Falzoni.Domain.Interfaces.Base
{
    public interface IUnitOfWork : IDisposable
    {
        DbContextTransaction BeginTransaction();

        void Commit();

        void RollBack();
    }
}
