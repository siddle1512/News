using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using News.Domain.Repositories;
using News.Infracstructure.Data;
using News.Infracstructure.Repositories;

namespace News.Infracstructure.Extensions
{
    public static class InfraServices
    {
        public static IServiceCollection AddInfracServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<NewsDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SqlData"))
            );
            serviceCollection.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            serviceCollection.AddScoped<IArticleRepository, ArticleRepository>();
            serviceCollection.AddScoped<IUserRepository, UserRepository>();
            serviceCollection.AddScoped<IRoleRepository, RoleRepository>();
            serviceCollection.AddScoped<ICategoryRepository, CategoryRepository>();

            return serviceCollection;
        }
    }
}
