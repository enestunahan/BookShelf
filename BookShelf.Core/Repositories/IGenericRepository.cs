using BookShelf.Core.Abstract;
using System.Linq.Expressions;

namespace BookShelf.Core.Repositories
{
    public interface IGenericRepository<TEntity,TKey> where TEntity : class,  IEntity
    {
        IQueryable<TEntity> GetAllAsync(bool trackChanges);
        IQueryable<TEntity>  GetAllByCondition(Expression<Func<TEntity, bool>> expression , bool trackChanges);
        Task<TEntity> GetByIdAsync(TKey id);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
