using HRMSoftware.Infrastructure.Abstracts;
using HRMSoftware.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HRMSoftware.Data.EF
{
    public class RepositoryBase<T> : IRepositoryBase<T>, IDisposable where T : HRMBaseEntity
    {
        private readonly AppDbContext _context;
        public RepositoryBase(AppDbContext context)
        {
            this._context = context;
        }
        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items = items.Include(includeProperty);
                }
            }

            return items.Where(predicate);
        }

        public T FindById(Guid id)
        {
            T items = _context.Set<T>().FirstOrDefault(p => p.ID == id);
            return items;
        }

        public IQueryable<T> Includes(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items = items.Include(includeProperty);
                }
            }

            return items;
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Remove(Guid id)
        {
            _context.Set<T>().Remove(FindById(id));
        }

        public void RemoveRange(List<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
