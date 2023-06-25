using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quizer.DataAccess.Persistance;

namespace Quizer.DataAccess
{
    public static class DataAccessInjection
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<DbContext, QuizerDbContext>();

            return services;
        }
    }
}
