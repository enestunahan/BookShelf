using BookShelf.Core.Abstract;

namespace BookShelf.Core.Models
{
    public class Author : BaseEntity<Guid> , IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => 
            string.Concat(FirstName, " " , LastName);
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public List<Book> Books { get; set; }
    }
}
