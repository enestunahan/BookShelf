namespace BookShelf.Core.DTOs
{
    public abstract class BaseDto<T>
    {
        public T Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
