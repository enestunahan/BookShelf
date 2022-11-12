using BookShelf.Core.DTOs;

namespace BookShelf.Core.Services
{
    public interface IAuthorService : IService<AuthorDto, Guid>
    {
    }
}
