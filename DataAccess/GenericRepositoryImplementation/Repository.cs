using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.GenericRepositoryImplementation
{
    public class Repository<T> : BaseRepository, IGenericRepository<T> where T : class
    {

        public IEnumerable<T> GetAll(Func<IQueryable<T>, IQueryable<T>> func = null)
        {
            var dbSet = _context.Set<T>();
            if(func != null)
            {
                return func(dbSet);
            }
            return dbSet.ToList();
        }
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        //Instead of calling _context.SaveChanges() in every method
        //public void Save()
        //{
        //    _context.SaveChanges();
        //}
    }
}
