using System;
using RepositoryPattern.Data;
using RepositoryPattern.Domain;
using RepositoryPattern.Transactions;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adding new Customer
            var uw = new UnitOfWork(new DataContext());
            uw.Customers.Add(new Customer {Id = 1, Name = "Daniel Tiago Braga"});
            uw.Commit();
        }
    }
}
