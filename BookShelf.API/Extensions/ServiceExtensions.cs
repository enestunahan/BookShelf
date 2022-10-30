using BookShelf.Repository.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace BookShelf.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("MsSqlConnnection"));
            });
        }
    }
}
