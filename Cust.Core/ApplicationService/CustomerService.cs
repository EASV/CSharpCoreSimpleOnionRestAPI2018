using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cust.Core.DomainService;
using Cust.Core.Entity;

namespace Cust.Core.ApplicationService
{
    public class CustomerService : AbstractUnitOfWorkService, ICustomerService
    {
        public CustomerService(IUnitOfWork uow): base(uow) {}

        public Customer CreateCustomer(Customer customer)
        {
            var createdCustomer = _unitOfWork.CustomerRepository.Create(customer);
            _unitOfWork.Commit();
            return createdCustomer;
        }

        public Customer DeleteCustomer(int id)
        {
            var cust = _unitOfWork.CustomerRepository.Delete(id);
            _unitOfWork.Commit();
            return cust;
        }

        public Customer getCustomerById(int id)
        {
            return  _unitOfWork.CustomerRepository.Get(id);
        }

        public List<Customer> GetCustomers()
        {
            return _unitOfWork.CustomerRepository.GetAll().ToList();
        }

        public Customer UpdateCustomer(Customer customerChanged)
        {
            var customerDB = _unitOfWork.CustomerRepository.Get(customerChanged.Id);
            customerDB.Firstname = customerChanged.Firstname;
            customerDB.Lastname = customerChanged.Lastname;
            customerDB.Address = customerChanged.Address;
            _unitOfWork.Commit();
            return customerDB;
        }

        public Customer UpdateCustomerEmail(int id, string email)
        {
            var customerDB = _unitOfWork.CustomerRepository.Get(id);
            customerDB.EMail = customerDB.EMail;
            _unitOfWork.Commit();
            return customerDB;
        }
    }
}
