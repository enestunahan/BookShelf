using BookShelf.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShelf.Repository.Configurations
{
    public class BookDetailConfiguration : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ISBN)
                .IsRequired();

            builder.Property(x => x.Country)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x=> x.UpdatedDate)
                .HasDefaultValue(null);

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder.HasOne(x => x.Book)
                .WithOne(x => x.BookDetail)
                .HasForeignKey<BookDetail>(x => x.BookId);           
        }
    }
}
