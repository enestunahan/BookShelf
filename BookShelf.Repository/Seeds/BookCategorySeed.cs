using BookShelf.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShelf.Repository.Seeds
{
    public class BookCategorySeed : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasData
              (
                  new BookCategory { Id = Guid.NewGuid(), BookId = Guid.Parse("8F5FF94D-95E5-403B-87A1-772D4F92D389"), CategoryId = 1 },
                  new BookCategory { Id = Guid.NewGuid(), BookId = Guid.Parse("8F5FF94D-95E5-403B-87A1-772D4F92D389"), CategoryId = 2 },
                  new BookCategory { Id = Guid.NewGuid(), BookId = Guid.Parse("2F01B12B-E101-4BEF-AC48-6477CD922512"), CategoryId = 1 },
                  new BookCategory { Id = Guid.NewGuid(), BookId = Guid.Parse("2F01B12B-E101-4BEF-AC48-6477CD922512"), CategoryId = 2 },
                  new BookCategory { Id = Guid.NewGuid(), BookId = Guid.Parse("7740C465-3549-40E8-8A34-1EDE6B02BFFF"), CategoryId = 1 },
                  new BookCategory { Id = Guid.NewGuid(), BookId = Guid.Parse("7740C465-3549-40E8-8A34-1EDE6B02BFFF"), CategoryId = 2 },
                  new BookCategory { Id = Guid.NewGuid(), BookId = Guid.Parse("160FBEAF-7685-41BE-B0AD-151CBD357909"), CategoryId = 1 },
                  new BookCategory { Id = Guid.NewGuid(), BookId = Guid.Parse("160FBEAF-7685-41BE-B0AD-151CBD357909"), CategoryId = 3 },
                  new BookCategory { Id = Guid.NewGuid(), BookId = Guid.Parse("EF074B57-3699-47D6-A22C-7C6E7725A2B3"), CategoryId = 4 },
                  new BookCategory { Id = Guid.NewGuid(), BookId = Guid.Parse("EF074B57-3699-47D6-A22C-7C6E7725A2B3"), CategoryId = 5 }
              );
        }
    }
}
