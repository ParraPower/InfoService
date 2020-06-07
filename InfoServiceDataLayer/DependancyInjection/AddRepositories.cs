using InfoServiceDataLayer.Models.Interfaces;
using InfoServiceDataLayer.Repositories.Implementations;
using InfoServiceDataLayer.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoServiceDataLayer.DependancyInjection
{
    public static partial class IServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
