using BookShelf.Core.Abstract;

namespace BookShelf.Core.Models
{
    public class Book : BaseEntity<Guid> , IEntity
    {
        public string Name { get; set; }
        public BookDetail BookDetail { get; set; }     
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public List<BookCategory> BookCategory { get; set; }
    }
}
