using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Mundipagg.Domain.Interfaces;

namespace Mundipagg.Infra.CrossCutting.InversionOfControl
{
    public static class MundipaggStoreDatabaseSettingsDependency
    {
        public static void AddMundipaggStoreDatabaseSettingsDependency(this IServiceCollection sevice)
        {
            sevice.AddSingleton<IMundipaggStoreDatabaseSettings>(sp => sp.GetRequiredService<IOptions<MundipaggStoreDatabaseSettings>>().Value);
        }
    }
}
