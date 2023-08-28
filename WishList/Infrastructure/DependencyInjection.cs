using Domain;
using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>();
            services.AddScoped<IWishRepository, WishRepository>();
            services.AddScoped<IUnitOfWork>(sp => sp.GetService<ApplicationContext>());

        }
    }
    
}
