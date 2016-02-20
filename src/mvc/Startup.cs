using Microsoft.AspNet.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Mvc
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddMvc();
        }
        
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Root}/{action=Get}");
            });
        }
    }
    
}