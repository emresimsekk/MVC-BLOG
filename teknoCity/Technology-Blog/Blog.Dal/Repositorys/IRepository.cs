using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Blog.Dal
{
    public interface IRepository<T> where T : class
    {
        List<T> List();

        int Insert(T obj);
        int Update(T obj);
        int Delete(T obj);

        int Save();

        List<T> OrderByTakeList(Expression<Func<T, DateTime>> orderByDesc);
        List<T> List(Expression<Func<T, bool>> where);
         T Find(Expression<Func<T,bool>> where);//  id=5 yolla 


    }
}