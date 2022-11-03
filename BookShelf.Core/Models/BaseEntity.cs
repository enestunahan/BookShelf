namespace BookShelf.Core.Models
{
    public abstract class BaseEntity <T> 
    {
        public T Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
