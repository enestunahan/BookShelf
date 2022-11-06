using BookShelf.Core.Models;
using BookShelf.Core.Repositories;
using BookShelf.Repository.DbContexts;

namespace BookShelf.Repository.Repositories
{
    public class AuthorRepository : GenericRepository<Author, Guid>, IAuthorRepository
    {
        public AuthorRepository(AppDbContext context) : base(context)
        {
        }
    }
}
