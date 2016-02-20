using Microsoft.AspNet.Mvc;

namespace Controllers
{
    public class GreetingController : Controller
    {
        public object Get() 
        {
            return "Hello, world!";
        }
    }    
}
