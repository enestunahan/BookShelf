using BookShelf.Core.Abstract;

namespace BookShelf.Core.Models
{
    public class BookDetail : BaseEntity<Guid> , IEntity
    {
        public short ReleaseYear { get; set; }
        public short Pages { get; set; }
        public string ISBN { get; set; }
        public string Country { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }       
    }
}
