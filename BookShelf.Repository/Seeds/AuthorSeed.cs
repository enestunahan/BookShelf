using BookShelf.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShelf.Repository.Seeds
{
    public class AuthorSeed : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData
             (
             new Author { Id = Guid.Parse("406578B9-D472-40A3-893F-3CF067A8D576"), FirstName = "Sabahattin", LastName = "Ali", DateOfBirth = new DateTime(1907, 02, 25), DateOfDeath = new DateTime(1948, 04, 02) },
             new Author { Id = Guid.Parse("5123CEF2-1F48-4A06-9D80-2190835194A3"), FirstName = "Joanne", LastName = "Rowling", DateOfBirth = new DateTime(1965, 07, 31) },
             new Author { Id = Guid.Parse("1C6447EF-86A2-49E2-B092-CD605942E899"), FirstName = "Reşat Nuri", LastName = "Güntekin", DateOfBirth = new DateTime(1889, 11, 25), DateOfDeath = new DateTime(1956, 12, 07) },
             new Author { Id = Guid.Parse("5C8C320B-F8AA-4FA9-B776-2DDA1C7F2FAB"), FirstName = "Robert Cecil", LastName = "Martin", DateOfBirth = new DateTime(1952, 11, 05) }
             );
        }
    }
}
