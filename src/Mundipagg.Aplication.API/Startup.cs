using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mundipagg.Infra.CrossCutting;
using Mundipagg.Infra.CrossCutting.InversionOfControl;
using Mundipagg.Services.API.Configurations;

namespace Mundipagg.Services.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();
            services.AddControllers();
            services.AddMundipaggStoreDatabaseSettingsDependency();
            services.DependenceInterfaces();
            services.AddAutoMapperConfiguration();
            services.Configure<MundipaggStoreDatabaseSettings>(Configuration.GetSection(nameof(MundipaggStoreDatabaseSettings)));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
