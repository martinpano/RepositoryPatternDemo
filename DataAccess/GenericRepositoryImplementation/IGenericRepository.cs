using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.GenericRepositoryImplementation
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null);
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
