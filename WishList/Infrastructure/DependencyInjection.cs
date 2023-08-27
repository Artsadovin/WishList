using Domain;
using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>();
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddScoped<IUnitOfWork>(sp => sp.GetService<ApplicationContext>());

        }
    }
    
}
