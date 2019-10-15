using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.GenericRepositoryImplementation
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Func<IQueryable<T>, IQueryable<T>> func = null);
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
