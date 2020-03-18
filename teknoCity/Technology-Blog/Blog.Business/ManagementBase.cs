using Blog.Dal;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.Business
{
    public class ManagementBase<T> : IRepository<T> where T : class
    {
        private RepositoryBase<T> Repo = new RepositoryBase<T>();

        public virtual int Delete(T obj)
        {
            return Repo.Delete(obj);
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return Repo.Find(where);
        }

        public virtual int Insert(T obj)
        {
            return Repo.Insert(obj);
        }

        public virtual List<T> List()
        {
            return Repo.List();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return Repo.List(where);
        }

        public List<T> OrderByTakeList(Expression<Func<T, DateTime>> orderByDesc)
        {
            return Repo.OrderByTakeList(orderByDesc);
        }

        public virtual int Save()
        {
            return Repo.Save();
        }

        public virtual int Update(T obj)
        {
            return Repo.Update(obj);
        }

       

    }
}
