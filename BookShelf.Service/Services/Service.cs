using BookShelf.Core.Abstract;
using BookShelf.Core.Repositories;
using BookShelf.Core.Services;
using BookShelf.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShelf.Service.Services
{
    public class Service<TEntity, TKey> : IService<TEntity, TKey> where TEntity : class, IEntity, new()
    {
        private readonly IGenericRepository<TEntity, TKey> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public Service(IGenericRepository<TEntity,TKey> reposityory, IUnitOfWork unitOfWork)
        {
            _repository = reposityory;
            _unitOfWork = unitOfWork;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
          await _repository.AddAsync(entity);
          await _unitOfWork.CommitAsync();
          return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(bool trackChanges)
        {
           return  await _repository.GetAllAsync(trackChanges).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllByCondition(Expression<Func<TEntity, bool>> expression, bool trackChanges)
        {
            return await _repository.GetAllByCondition(expression,trackChanges).ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(TEntity entity)
        {
            _repository.Remove(entity);
           await _unitOfWork.CommitAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            _repository.RemoveRange(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _repository.Update(entity);
            await _unitOfWork.CommitAsync();
        }
    }
}
