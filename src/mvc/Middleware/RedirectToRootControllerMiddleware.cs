using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace Middleware
{
    public class RedirectToRootControllerMiddleware
    {
        private RequestDelegate _next;

        public RedirectToRootControllerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var path = context.Request.Path;
            Console.WriteLine($"RedirectToRootControllerMiddleware: {path}");

            if (path == "/")
            {
                context.Request.Path = PathString.FromUriComponent("/root");
            }
            
            await _next(context);
        }
    }    
}
