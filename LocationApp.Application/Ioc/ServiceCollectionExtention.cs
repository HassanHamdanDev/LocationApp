using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocationApp.Infrastructure.EntityFramework.Ioc;
using LocationApp.Application.Places;
using LocationApp.Application.Places.Mappings;

namespace LocationApp.Application.Ioc
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.RegisterInfastructureEntityFramework();

            services.AddAutoMapper(typeof(ServiceCollectionExtention).Assembly);
            services.RegisterApplicationServices();
            return services;
        }

        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IPlacesService, PlacesService>();
            return services;
        }
    }
}
