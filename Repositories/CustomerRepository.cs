using RepositoryPattern.Data;
using RepositoryPattern.Domain;

namespace RepositoryPattern.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DataContext context) : base(context)
        {
            
        }
    }
}