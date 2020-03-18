using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Blog.Dal
{
    public class RepositoryBase<T> : ContextBase, IRepository<T> where T : class
    {
        private DbSet<T> _objectSet;
        public RepositoryBase()
        {
            _objectSet = context.Set<T>();
            

        }

        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }
        public int Update(T obj)
        {
            return Save();
        }
        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }
        public List<T> List()
        {
            return _objectSet.ToList();
        }
     
        public int Save()
        {
            return context.SaveChanges();
        }

        public List<T> OrderByTakeList(Expression<Func<T, DateTime>> orderByDesc)
        {
            return _objectSet.OrderByDescending(orderByDesc).ToList();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }
    }
}
