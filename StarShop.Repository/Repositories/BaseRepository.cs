
using StarShop.Domain.Contracts;
using System.Collections.Generic;

namespace StarShop.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public BaseRepository()
        {

        }

        public void Add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> getAll()
        {
            throw new System.NotImplementedException();
        }

        public TEntity getById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
