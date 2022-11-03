using BookShelf.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShelf.Repository.Seeds
{
    public class BookDetailSeed : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasData(
               new BookDetail { Id = Guid.NewGuid(), BookId = Guid.Parse("8F5FF94D-95E5-403B-87A1-772D4F92D389"), ReleaseYear = 1922, Pages = 409, Country = "Türkiye", ISBN = "9785486037986" },
               new BookDetail { Id = Guid.NewGuid(), BookId = Guid.Parse("2F01B12B-E101-4BEF-AC48-6477CD922512"), ReleaseYear = 1937, Pages = 222, Country = "Türkiye", ISBN = "9786051215877" },
               new BookDetail { Id = Guid.NewGuid(), BookId = Guid.Parse("7740C465-3549-40E8-8A34-1EDE6B02BFFF"), ReleaseYear = 1928, Pages = 160, Country = "Türkiye", ISBN = "9789751026569" },
               new BookDetail { Id = Guid.NewGuid(), BookId = Guid.Parse("160FBEAF-7685-41BE-B0AD-151CBD357909"), ReleaseYear = 1998, Pages = 314, Country = "İngiltere", ISBN = "9781408855669" },
               new BookDetail { Id = Guid.NewGuid(), BookId = Guid.Parse("EF074B57-3699-47D6-A22C-7C6E7725A2B3"), ReleaseYear = 2008, Pages = 464, Country = "Amerika", ISBN = "978-0132350884" }
               );
        }
    }
}
