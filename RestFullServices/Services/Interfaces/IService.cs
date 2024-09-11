using System.Linq.Expressions;

namespace Services
{
    public interface IService<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> AddAllAsync(IEnumerable<TEntity> tList);
        Task<TEntity> AddAsync(TEntity t);
        Task<ICollection<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<ICollection<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(int id);
        Task<TEntity> RemoveAsync(int key);
        Task<TEntity> UpdateAsync(TEntity updated, int key);
    }
}

