using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HRMSoftware.Infrastructure.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(Guid id);
        void RemoveRange(List<T> entities);
        T FindById(Guid id);
        IQueryable<T> Includes(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
    }
}
