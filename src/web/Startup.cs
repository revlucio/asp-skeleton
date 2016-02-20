using System.IO;
using Microsoft.AspNet.Builder;

namespace Web
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async context => {
                using (var writer = new StreamWriter(context.Response.Body))
                {
                    await writer.WriteAsync("Hello, world!");
                }
            });
        }
    } 
}