using RepositoryPattern.Data;
using RepositoryPattern.Repositories;

namespace RepositoryPattern.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        #region "Here we need to put all repository interfaces of our application"
        public ICustomerRepository Customers { get; }
        #endregion

        public UnitOfWork(DataContext context) 
        {
            _context = context;

            Customers = new CustomerRepository(context);
        }

        public void Commit() {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}