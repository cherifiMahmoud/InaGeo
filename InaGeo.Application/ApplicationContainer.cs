using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace InaGeo.Application
{
    public static class ApplicationContainer
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
