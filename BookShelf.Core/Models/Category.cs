using BookShelf.Core.Abstract;

namespace BookShelf.Core.Models
{
    public class Category : BaseEntity<short> , IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
