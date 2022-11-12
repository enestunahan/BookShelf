using BookShelf.Core.Abstract;
using System.Linq.Expressions;

namespace BookShelf.Core.Services
{
    public interface IService<TDto , TKey> where TDto : class, IDto , new()
    {
        Task<IEnumerable<TDto>> GetAllAsync(bool trackChanges);
        Task<IEnumerable<TDto>> GetAllByCondition(Expression<Func<TDto, bool>> expression, bool trackChanges);
        Task<TDto> GetByIdAsync(TKey id);
        Task UpdateAsync(TDto dto);
        Task<TDto> AddAsync(TDto dto);
        Task<IEnumerable<TDto>> AddRangeAsync(IEnumerable<TDto> dtos);
        Task RemoveAsync(TDto dto);
        Task RemoveRangeAsync(IEnumerable<TDto> dtos);
    }
}
