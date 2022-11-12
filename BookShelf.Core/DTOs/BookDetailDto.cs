using BookShelf.Core.Abstract;

namespace BookShelf.Core.DTOs
{
    public class BookDetailDto : BaseDto<Guid> , IDto
    {
        public short ReleaseYear { get; set; }
        public short Pages { get; set; }
        public string ISBN { get; set; }
        public string Country { get; set; }
        public Guid BookId { get; set; }
    }
}
