using BookShelf.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShelf.Repository.Configurations
{
    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.IsDeleted)
                 .HasDefaultValue(false);

            builder.Property(x => x.UpdatedDate)
                .HasDefaultValue(null);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.BookCategories)
                .HasForeignKey(x => x.CategoryId);

            builder.HasOne(x => x.Book)
                .WithMany(x => x.BookCategory)
                .HasForeignKey(x => x.BookId);
        }
    }
}
