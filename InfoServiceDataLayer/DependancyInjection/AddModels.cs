using InfoServiceDataLayer.Models.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoServiceDataLayer.DependancyInjection
{
    public static partial class IServiceCollectionExtension
    {
        public static IServiceCollection AddModels(this IServiceCollection services)
        {
            services.AddScoped<IUser, Models.Implementations.User>();
            return services;
        }
    }
}
