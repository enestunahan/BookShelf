using BookShelf.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShelf.Repository.Seeds
{
    public class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = Guid.Parse("8F5FF94D-95E5-403B-87A1-772D4F92D389"), Name = "Çalıkuşu", AuthorId = Guid.Parse("1C6447EF-86A2-49E2-B092-CD605942E899") },
                new Book { Id = Guid.Parse("2F01B12B-E101-4BEF-AC48-6477CD922512"), Name = "Kuyucaklı Yusuf", AuthorId = Guid.Parse("406578B9-D472-40A3-893F-3CF067A8D576") },
                new Book { Id = Guid.Parse("7740C465-3549-40E8-8A34-1EDE6B02BFFF"), Name = "Acımak", AuthorId = Guid.Parse("406578B9-D472-40A3-893F-3CF067A8D576") },
                new Book { Id = Guid.Parse("160FBEAF-7685-41BE-B0AD-151CBD357909"), Name = "Harry Potter Sırlar Odası", AuthorId = Guid.Parse("5123CEF2-1F48-4A06-9D80-2190835194A3") },
                new Book { Id = Guid.Parse("EF074B57-3699-47D6-A22C-7C6E7725A2B3"), Name = "Clean Code", AuthorId = Guid.Parse("5C8C320B-F8AA-4FA9-B776-2DDA1C7F2FAB") }
                );
        }
    }
}
