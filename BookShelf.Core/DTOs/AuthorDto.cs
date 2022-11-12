using BookShelf.Core.Abstract;

namespace BookShelf.Core.DTOs
{
    public class AuthorDto : BaseDto<Guid> , IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName =>
         string.Concat(FirstName, " ", LastName);
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }

    }
}
