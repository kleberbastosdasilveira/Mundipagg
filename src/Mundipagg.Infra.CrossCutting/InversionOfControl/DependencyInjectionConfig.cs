using Microsoft.Extensions.DependencyInjection;
using Mundipagg.Domain.Interfaces;
using Mundipagg.Infra.Data.Context;
using Mundipagg.Infra.Data.Repository;

namespace Mundipagg.Infra.CrossCutting.InversionOfControl
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection DependenceInterfaces(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryProduto, RepositoryProduto>();
            services.AddSingleton<MundipaggDb>();
            return services;
        }
    }
}
