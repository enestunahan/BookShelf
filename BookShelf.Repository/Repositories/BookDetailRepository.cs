using BookShelf.Core.Models;
using BookShelf.Core.Repositories;
using BookShelf.Repository.DbContexts;

namespace BookShelf.Repository.Repositories
{
    public class BookDetailRepository : GenericRepository<BookDetail, Guid>, IBookDetailRepository
    {
        public BookDetailRepository(AppDbContext context) : base(context)
        {
        }
    }
}
