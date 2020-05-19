using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Domain;

namespace RepositoryPattern.Data
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=CustomersDB;Integrated Security=True");
        }

    }
}
