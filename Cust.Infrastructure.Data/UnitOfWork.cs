using Cust.Core.DomainService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cust.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private CustomerAppDBContext _context;

        public ICustomerRepository CustomerRepository { get; internal set; }

        public UnitOfWork(  CustomerAppDBContext context, 
                            ICustomerRepository customerRepository)
        {
            this._context = context;
            this.CustomerRepository = customerRepository;
        }

        public int Commit()
        {
            return this._context.SaveChanges();
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
