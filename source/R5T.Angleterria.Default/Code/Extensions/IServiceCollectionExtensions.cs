using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Angleterria.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DefaultVisualStudioStringlyTypedPathPartsOperator"/> implementation of <see cref="IVisualStudioStringlyTypedPathPartsOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultVisualStudioStringlyTypedPathPartsOperator(this IServiceCollection services)
        {
            services.AddSingleton<IVisualStudioStringlyTypedPathPartsOperator, DefaultVisualStudioStringlyTypedPathPartsOperator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultVisualStudioStringlyTypedPathPartsOperator"/> implementation of <see cref="IVisualStudioStringlyTypedPathPartsOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IVisualStudioStringlyTypedPathPartsOperator> AddDefaultVisualStudioStringlyTypedPathPartsOperatorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudioStringlyTypedPathPartsOperator>(() => services.AddDefaultVisualStudioStringlyTypedPathPartsOperator());
            return serviceAction;
        }
    }
}
