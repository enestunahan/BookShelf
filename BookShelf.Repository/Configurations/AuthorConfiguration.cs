using BookShelf.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShelf.Repository.Configurations
{
    public class AuthorConfiguration : CustomConfigurations<Author,Guid>
    {
        public override void Configure(EntityTypeBuilder<Author> builder)
        {

            builder.Ignore(x => x.FullName);

            builder.Property(x => x.FirstName)
              .IsRequired()
              .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .HasMaxLength(50);

            builder.HasMany(x=>x.Books)
                .WithOne(x=>x.Author)
                .HasForeignKey(x=>x.AuthorId);
        }
    }
}
