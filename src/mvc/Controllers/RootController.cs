using Microsoft.AspNet.Mvc;

namespace Controllers
{
    public class RootController : Controller
    {
        public object Get() 
        {
            return new {
                greeting = "/greeting"   
            };
        }
    }    
}
