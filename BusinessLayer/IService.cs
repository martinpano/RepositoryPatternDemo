using DataAccess.Repository_Ordinary;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Remove(int id);
    }
}
