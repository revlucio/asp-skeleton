using Microsoft.AspNet.Mvc;

namespace Controllers
{
    public class RootController : Controller
    {
        public object Get() 
        {
            return new {
                greeting = this.Url.Action<GreetingController>(c => c.Get()),
                people = this.Url.Action<PersonController>(c => c.List())
            };
        }
    }    
}
