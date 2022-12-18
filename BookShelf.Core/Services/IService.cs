using System.Linq.Expressions;

namespace BookShelf.Core.Services
{
    public interface IService<TEntity , TKey> where TEntity : class, new()
    {

        Task<IEnumerable<TEntity>> GetAllAsync(bool trackChanges);
        Task<IEnumerable<TEntity>> GetAllByCondition(Expression<Func<TEntity, bool>> expression, bool trackChanges);
        Task<TEntity> GetByIdAsync(TKey id);
        Task UpdateAsync(TEntity entity);
        Task<TEntity> AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);
        Task RemoveAsync(TEntity entity);
        Task RemoveRangeAsync(IEnumerable<TEntity> entities);
    }
}
