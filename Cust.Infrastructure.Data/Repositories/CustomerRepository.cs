using Cust.Core.DomainService;
using Cust.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cust.Infrastructure.Data.Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(CustomerAppDBContext context): base(context) {}

        public Customer Create(Customer customer)
        {
            return _context.Customers.Add(customer).Entity;
        }

        public Customer Delete(int id)
        {
            var cust = _context.Customers.Find(id);
            if (cust == null) return null;

            return _context.Customers.Remove(cust).Entity;
        }

        public Customer Get(int id)
        {
            return _context.Customers.Find(id);

        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }

        public IEnumerable<Customer> GetAllById(List<int> ids)
        {
            if (ids == null) { return null; }

            return _context.Customers.Where(a => ids.Contains(a.Id));
        }
    }
}
