using BookShelf.Core.Models;
using BookShelf.Repository.DbContexts;

namespace BookShelf.Repository.Repositories
{
    public class BookCategoryRepository : GenericRepository<BookCategory, Guid>
    {
        public BookCategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
