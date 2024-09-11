using Data;
using System.Linq.Expressions;

namespace Services
{
    public abstract class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> repository;

        public Service(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public virtual async Task<TEntity> GetAsync(int id)
        {
            try
            {
                var result = await repository.GetAsync(id);
                return result;
            }
            catch
            {
                throw;
            }
        }

        public virtual async Task<ICollection<TEntity>> GetAllAsync()
        {
            try
            {
                var result = await repository.GetAllAsync();
                return result;
            }
            catch
            {
                throw;
            }
        }

        public virtual async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                var result = await repository.FindAsync(predicate);
                return result;
            }
            catch
            {
                throw;
            }
        }

        public virtual async Task<ICollection<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                var result = await repository.FindAllAsync(predicate);
                return result;
            }
            catch
            {
                throw;
            }
        }

        public virtual async Task<TEntity> AddAsync(TEntity t)
        {
            try
            {
                var result = await repository.AddAsync(t);
                await repository.SaveChangesAsync();
                return result;
            }
            catch
            {
                throw;
            }
        }

        public virtual async Task<IEnumerable<TEntity>> AddAllAsync(IEnumerable<TEntity> people)
        {
            try
            {
                var result = await repository.AddAllAsync(people);
                await repository.SaveChangesAsync();
                return result;
            }
            catch
            {
                throw;
            }
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity updated, int key)
        {
            try
            {
                var result = await repository.UpdateAsync(updated, key);
                await repository.SaveChangesAsync();
                return result;
            }
            catch
            {
                throw;
            }
        }

        public virtual async Task<TEntity> RemoveAsync(int key)
        {
            try
            {
                var result = await repository.RemoveAsync(key);
                if (result == null)
                    return null;
                await repository.SaveChangesAsync();
                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}

