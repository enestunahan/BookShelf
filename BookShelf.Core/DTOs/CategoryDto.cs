using BookShelf.Core.Abstract;

namespace BookShelf.Core.DTOs
{
    public class CategoryDto : BaseDto<short> , IDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
