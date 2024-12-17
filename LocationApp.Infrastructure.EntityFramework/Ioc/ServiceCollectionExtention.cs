using LocationApp.Infrastructure.EntityFramework.Repositories;
using LocationApp.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Infrastructure.EntityFramework.Ioc
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection RegisterInfastructureEntityFramework(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IPlaceRepository, PlaceRepository>();
            return services;
        }
    }
}
