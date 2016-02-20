using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace Middleware
{
    public class AddMethodToRequestPathMiddleware
    {
        private RequestDelegate _next;

        public AddMethodToRequestPathMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var path = context.Request.Path.ToString().TrimEnd('/');
            var method = context.Request.Method;
            
            context.Request.Path = PathString.FromUriComponent($"{path}/{method}");
            await _next(context);
        }
    }    
}
