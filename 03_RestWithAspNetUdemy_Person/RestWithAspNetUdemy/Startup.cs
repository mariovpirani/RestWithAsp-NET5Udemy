using RestWithAspNetUdemy.Services;
using RestWithAspNetUdemy.Services.Implementantions;

namespace RestWithAspNetUdemy
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Dependency Injection
            services.AddScoped<IPersonService, PersonServiceImplementation>();
        }
    }
}

