using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using VotingApp.Persistence.Context;

namespace VotingApp.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VotingContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SQLServer-ConnectionString"),
                b => b.MigrationsAssembly(typeof(VotingContext).Assembly.FullName))
                .LogTo(Console.WriteLine, LogLevel.Information)); // disable for production;

            return services;
        }
    }
}