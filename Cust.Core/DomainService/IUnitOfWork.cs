using System;

namespace Cust.Core.DomainService
{
    public interface IUnitOfWork: IDisposable
    {
        ICustomerRepository CustomerRepository { get;  }

        int Commit();
    }
}
