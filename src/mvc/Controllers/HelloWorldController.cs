using Microsoft.AspNet.Mvc;

namespace Controllers
{
    [Route("/")]
    public class HelloWorldController : Controller
    {
        [HttpGet]
        public object Get() 
        {
            return "Hello, world from MVC!";
        }    
    }    
}
