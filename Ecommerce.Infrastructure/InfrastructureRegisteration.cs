using Ecommerce.Core.Interfaces;
using Ecommerce.Infrastructure.Data;
using Ecommerce.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure
{
    public static class InfrastructureRegisteration
    {
        public static IServiceCollection infrastructureConfiguration(this IServiceCollection services , IConfiguration configuration)
        {
            //services.AddTransient;
            //services.AddScoped;
            //services.AddSingleton;

            services.AddScoped(typeof(IGenericRepository<>) , typeof(GenericRepository<>));
            // Apply unit of work pattern
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            // Apply DdContext
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ApplicationDbContextConnection")); // Replace with your actual connection string
            });
            return services;
        }
    }
}
