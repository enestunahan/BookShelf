using BookShelf.Core.Models;
using BookShelf.Repository.Configurations;
using BookShelf.Repository.Seeds;
using Microsoft.EntityFrameworkCore;

namespace BookShelf.Repository.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new BookCategoryConfiguration());
            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new BookDetailConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());

            builder.ApplyConfiguration(new AuthorSeed());
            builder.ApplyConfiguration(new BookCategorySeed());
            builder.ApplyConfiguration(new BookDetailSeed());
            builder.ApplyConfiguration(new BookSeed());
            builder.ApplyConfiguration(new CategorySeed());
        }
    }
}
