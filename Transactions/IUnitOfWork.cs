using System;
using RepositoryPattern.Repositories;

namespace RepositoryPattern.Transactions
{
    public interface IUnitOfWork : IDisposable
    {
        #region "Here we need to put all repository interfaces of our application"
        ICustomerRepository Customers { get; }
        #endregion

        void Commit();
    }
}