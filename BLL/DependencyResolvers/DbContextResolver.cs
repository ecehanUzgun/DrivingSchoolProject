using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.DependencyResolvers
{//Extension method must be defined in a non-generic static class
    public static class DbContextResolver
    {
        public static void AddDbContextService(this IServiceCollection services)
        {
            ServiceProvider provider = services.BuildServiceProvider();

            IConfiguration? configuration = provider.GetService<IConfiguration>();

            services.AddDbContext<ProjectContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("EceConnection")));
        }
    }
}
