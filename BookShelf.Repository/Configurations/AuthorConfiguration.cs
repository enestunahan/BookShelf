using BookShelf.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShelf.Repository.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Ignore(x => x.FullName);

            builder.Property(x => x.FirstName)
              .IsRequired()
              .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .HasMaxLength(50);

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder.Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.UpdatedDate)
                .HasDefaultValue(null);

            builder.HasMany(x=>x.Books)
                .WithOne(x=>x.Author)
                .HasForeignKey(x=>x.AuthorId);
          


        }
    }
}
