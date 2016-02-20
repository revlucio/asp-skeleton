using System.IO;
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
            app.UseMvc();
            // app.Run(async context => {
            //     using (var writer = new StreamWriter(context.Response.Body))
            //     {
            //         await writer.WriteAsync("Hello, MVC world!");
            //     }
            // });
        }
    }
    
}