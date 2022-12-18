using BookShelf.Core.Models;
using BookShelf.Core.Repositories;
using BookShelf.Core.Services;
using BookShelf.Core.UnitOfWorks;

namespace BookShelf.Service.Services
{
    public class AuthorService : Service<Author, Guid>, IAuthorService
    {
        public AuthorService(IGenericRepository<Author, Guid> reposityory, IUnitOfWork unitOfWork) : base(reposityory, unitOfWork)
        {
        }
    }
}
