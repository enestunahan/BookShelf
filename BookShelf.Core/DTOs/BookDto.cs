using BookShelf.Core.Abstract;

namespace BookShelf.Core.DTOs
{
    public class BookDto : BaseDto<Guid> , IDto
    {
        public string Name { get; set; }
        public Guid AuthorId { get; set; }
    }
}
