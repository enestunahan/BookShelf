using BookShelf.Core.Models;
using BookShelf.Core.Repositories;
using BookShelf.Core.Services;
using BookShelf.Core.UnitOfWorks;

namespace BookShelf.Service.Services
{
    public class BookService : Service<Book, Guid>, IBookService
    {
        public BookService(IGenericRepository<Book, Guid> reposityory, IUnitOfWork unitOfWork) : base(reposityory, unitOfWork)
        {
        }
    }
}
