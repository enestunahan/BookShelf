using BookShelf.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShelf.Repository.Configurations
{
    public class BookDetailConfiguration : CustomConfigurations<BookDetail,Guid>
    {
        public override void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.Property(x => x.ISBN)
                .IsRequired();

            builder.Property(x => x.Country)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(x => x.Book)
                .WithOne(x => x.BookDetail)
                .HasForeignKey<BookDetail>(x => x.BookId);           
        }
    }
}
