using BookShelf.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShelf.Repository.Configurations
{
    public class BookCategoryConfiguration : CustomConfigurations<BookCategory,Guid>
    {
        public override void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasOne(x => x.Category)
                .WithMany(x => x.BookCategories)
                .HasForeignKey(x => x.CategoryId);

            builder.HasOne(x => x.Book)
                .WithMany(x => x.BookCategory)
                .HasForeignKey(x => x.BookId);
        }
    }
}
