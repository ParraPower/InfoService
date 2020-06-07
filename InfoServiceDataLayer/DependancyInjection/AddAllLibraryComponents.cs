using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoServiceDataLayer.DependancyInjection
{
    public static partial class IServiceCollectionExtension
    {
        public static IServiceCollection AddAllLibraryComponents(this IServiceCollection services)
        {
            services.AddModels();
            services.AddRepositories();

            return services; 
        }
    }
}
