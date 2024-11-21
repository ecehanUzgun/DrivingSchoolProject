using DAL.Repository.Abstracts;
using DAL.Repository.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.DependencyResolvers
{
    public static class RepositoryResolver
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
