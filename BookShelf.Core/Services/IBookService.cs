using BookShelf.Core.DTOs;

namespace BookShelf.Core.Services
{
    public interface IBookService : IService<BookDto,Guid>
    {
    }
}
