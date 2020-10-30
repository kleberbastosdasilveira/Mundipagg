using Microsoft.Extensions.DependencyInjection;
using Mundipagg.Aplication.Interfaces;
using Mundipagg.Aplication.Notificacoes;
using Mundipagg.Aplication.Services;
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
            services.AddScoped<IRepositoryProdutoService, ProdutoService>();
            services.AddScoped<IProdutoService, ProdutoServiceCrud>();
            services.AddScoped<INotificador, Notificador>();
            services.AddSingleton<MundipaggDb>();
            return services;
        }
    }
}
