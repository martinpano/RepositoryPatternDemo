using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.GenericRepositoryInterface
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Remove(int id);
    }
}
