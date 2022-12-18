using BookShelf.Core.Models;
using BookShelf.Core.Repositories;
using BookShelf.Core.Services;
using BookShelf.Core.UnitOfWorks;

namespace BookShelf.Service.Services
{
    public class BookDetailService : Service<BookDetail, Guid>, IBookDetailService
    {
        public BookDetailService(IGenericRepository<BookDetail, Guid> reposityory, IUnitOfWork unitOfWork) : base(reposityory, unitOfWork)
        {
        }
    }
}
