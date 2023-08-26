using DBRepository.Factories;
using DBRepository.Interfaces;
using DBRepository.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WishList
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            services.AddControllers();
            services.AddScoped<IRepositoryContextFactory, RepositoryContextFactory>(); // 1
            services.AddScoped<IWishRepository>(provider => new WishRepository(Configuration.GetConnectionString("DefaultConnection"), provider.GetService<IRepositoryContextFactory>())); // 2
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}