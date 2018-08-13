using Cust.Core.DomainService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cust.Core.ApplicationService
{
    public abstract class AbstractUnitOfWorkService
    {
        protected IUnitOfWork _unitOfWork;

        public AbstractUnitOfWorkService(IUnitOfWork uow) {
            _unitOfWork = uow;
        }
    }
}
