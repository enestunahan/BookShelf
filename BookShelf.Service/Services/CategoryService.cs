using BookShelf.Core.Models;
using BookShelf.Core.Repositories;
using BookShelf.Core.Services;
using BookShelf.Core.UnitOfWorks;

namespace BookShelf.Service.Services
{
    public class CategoryService : Service<Category, short>, ICategoryService
    {
        public CategoryService(IGenericRepository<Category, short> reposityory, IUnitOfWork unitOfWork) : base(reposityory, unitOfWork)
        {
        }
    }
}
