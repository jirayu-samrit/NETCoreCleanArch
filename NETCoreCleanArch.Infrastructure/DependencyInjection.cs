using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreCleanArch.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection ImplementMovieDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            // Add Database Service
            services.AddDbContext<MovieDbContext>(
                opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")
                , b => b.MigrationsAssembly(typeof(MovieDbContext).Assembly.FullName))
                , ServiceLifetime.Transient
                );

            services.AddScoped<IMovieDbContext>(provider => provider.GetService<MovieDbContext>());

            return services;
        }
    }
}
