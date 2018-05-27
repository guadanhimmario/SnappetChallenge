using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SnappetChallenge.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Insert(TEntity obj);
        TEntity FindById(Guid id);
        IEnumerable<TEntity> GetAll();
        TEntity Update(TEntity obj);
        void Remove(Guid id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}
