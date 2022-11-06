using BookShelf.Core.Models;
using BookShelf.Core.Repositories;
using BookShelf.Repository.DbContexts;

namespace BookShelf.Repository.Repositories
{
    public class BookRepository : GenericRepository<Book, Guid>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {
        }      
    }
}
