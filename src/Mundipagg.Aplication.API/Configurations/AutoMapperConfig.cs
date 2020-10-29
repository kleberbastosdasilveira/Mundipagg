using Microsoft.Extensions.DependencyInjection;
using Mundipagg.Aplication.AutoMapper;
using AutoMapper;

namespace Mundipagg.Services.API.Configurations
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DomainToViewModelMapping));
        }
    }
}
