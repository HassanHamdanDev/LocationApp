using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocationApp.Infrastructure.EntityFramework.Ioc;

namespace LocationApp.Application.Ioc
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.RegisterInfastructureEntityFramework();
            return services;
        }
    }
}
