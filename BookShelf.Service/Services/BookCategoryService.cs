using BookShelf.Core.Models;
using BookShelf.Core.Repositories;
using BookShelf.Core.Services;
using BookShelf.Core.UnitOfWorks;

namespace BookShelf.Service.Services
{
    public class BookCategoryService : Service<BookCategory, Guid>, IBookCategoryService
    {
        public BookCategoryService(IGenericRepository<BookCategory, Guid> reposityory, IUnitOfWork unitOfWork) : base(reposityory, unitOfWork)
        {
        }
    }
}
