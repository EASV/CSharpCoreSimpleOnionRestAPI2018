using Cust.Core.DomainService;
using Cust.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cust.Core.ApplicationService
{
    public interface ICustomerService
    {
        Customer CreateCustomer(Customer customer);
        List<Customer> GetCustomers();
        Customer getCustomerById(int id);
        Customer UpdateCustomer(Customer customer);
        Customer DeleteCustomer(int id);

        Customer UpdateCustomerEmail(int id, string email);
    }
}
