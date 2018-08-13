using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cust.Core.DomainService
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //C
        TEntity Create(TEntity itemToCreate);
        //R
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllById(List<int> ids);
        TEntity  Get(int Id);
        //U
        //No Update for Repository, It will be the task of Unit of Work
        //D
        TEntity Delete(int Id);
    }
}
