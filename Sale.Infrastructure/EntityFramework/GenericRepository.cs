using Microsoft.EntityFrameworkCore;
using Sale.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using Sale.Contract.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Infrastructure.EntityFramework
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {


        private AppDbContext _context = null;

        public GenericRepository(AppDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            var query = _context.Set<T>().AsQueryable();
            if (includes != null)
            {
                var result = includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
                var test = result.ToList();
                return test;
            }
            else
            {
                var result = query;
                return result.AsQueryable();
            }
        }
        public T GetById(int id)
        {
            
            return _context.Set<T>().Find(id);
        }
        public IQueryable<T> Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            if (includes != null)
            {
                var result = includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
                var test = result.ToList();
                return result;
            }
            else
            {
                var result = query;
                return result;
            }
          
          
        }
        public object Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            if (_context.SaveChanges() > 0)
            {
                return obj as object;
            }
            else
            {
                return null;
            }
            

        }
        public object Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            T entityInDb = this.GetById(entity.Id);
            if (entityInDb == null)
            {
                throw new KeyNotFoundException();
            }
            _context.Entry(entityInDb).CurrentValues.SetValues(entity);
            if (_context.SaveChanges() > 0)
            {
                return entity as object;
            }
            else
            {
                return null;
            }

        }
        public object Delete(int id)
        {
            T existing = GetById(id);
            _context.Set<T>().Remove(existing);
            if (_context.SaveChanges() > 0)
            {
                return existing as object;
            }
            else
            {
                return null;
            }

        }
        public void Remove(object id)
        {
            T existing = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(existing);
        

        }







    }
}
