using BookShelf.Core.Abstract;

namespace BookShelf.Core.DTOs
{
    public class BookCategoryDto : BaseDto<Guid> , IDto
    {
        public short CategoryId { get; set; }
        public Guid BookId { get; set; }

    }
}
