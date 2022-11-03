using BookShelf.Core.Abstract;
using BookShelf.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShelf.Repository.Configurations
{
    public class CustomConfigurations<TEntity,TKey> : IEntityTypeConfiguration<TEntity> 
        where TEntity : BaseEntity<TKey> , IEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.UpdatedDate)
                .HasDefaultValue(null);

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false);
        }
    }
}
