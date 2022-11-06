using BookShelf.Core.Models;
using BookShelf.Core.Repositories;
using BookShelf.Repository.DbContexts;

namespace BookShelf.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category, short>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
