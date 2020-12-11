using System;
using System.Collections.Generic;

namespace StarShop.Domain.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        TEntity getById(int id);
        IEnumerable<TEntity> getAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
