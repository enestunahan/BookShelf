using BookShelf.Core.Abstract;
using BookShelf.Core.Repositories;
using BookShelf.Repository.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShelf.Repository.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class, IEntity
    {

        protected AppDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet   = _context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity) => await _dbSet.AddAsync(entity);

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task<IQueryable<TEntity>> GetAllAsync(bool trackChanges)
        {
            return trackChanges ? await _dbSet.AsQueryable() : await _dbSet.AsQueryable().AsNoTrackingAsync();     
        }

        public async Task<IQueryable<TEntity>> GetAllByCondition(Expression<Func<TEntity, bool>> expression, bool trackChanges)
        {
            return trackChanges
                ? await _dbSet.Where(expression).AsQueryable()
                : await _dbSet.Where(expression).AsQueryable().AsNoTracking();
        }

        public async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Remove(TEntity entity) => _dbSet.Remove(entity);

        public void RemoveRange(IEnumerable<TEntity> entities) => _dbSet.RemoveRange(entities);

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
