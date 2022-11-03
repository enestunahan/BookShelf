using BookShelf.Core.Abstract;

namespace BookShelf.Core.Models
{
    public class BookCategory : BaseEntity<Guid> , IEntity
    {      
        public short CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
    }
}
