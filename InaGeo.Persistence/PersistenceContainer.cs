using InaGeo.Application.Contracts;
using InaGeo.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InaGeo.Persistence
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InaGeoDbContext>(options =>
              options.UseSqlServer(configuration.GetConnectionString("InabexConnectionString")));

            services.AddScoped(typeof(IAsyncRespository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IVersionRespository), typeof(VersionRepository));

            return services;
        }

    }
}
