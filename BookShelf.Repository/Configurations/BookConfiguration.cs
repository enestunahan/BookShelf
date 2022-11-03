using BookShelf.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShelf.Repository.Configurations
{
    public class BookConfiguration : CustomConfigurations<Book,Guid>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasOne(x => x.BookDetail)
                .WithOne(x => x.Book)
                .HasForeignKey<BookDetail>(x => x.BookId);
        }
    }
}
