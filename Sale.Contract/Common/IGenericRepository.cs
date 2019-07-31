using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Contract.Common
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes);
        T GetById(int id);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        object Insert(T obj);
        object Update(T obj);
        object Delete(int id);
        void Remove(object id);
        
        }
}
