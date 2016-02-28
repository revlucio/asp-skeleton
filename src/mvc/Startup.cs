using Microsoft.AspNet.Builder;
using Microsoft.Extensions.DependencyInjection;
using Controllers;

namespace Mvc
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddMvc().AddTypedRouting(routes =>
            {
                routes.Get("/", route => route.ToAction<RootController>(c => c.Get()));
                routes.Get("salutations", route => route.ToAction<GreetingController>(c => c.Get()));
                routes.Get("person", route => route.ToAction<PersonController>(c => c.List()));
                routes.Put("person", route => route.ToAction<PersonController>(c => c.Put(null)));
            });
        }
        
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes => routes.UseTypedRouting());
        }
    }
}