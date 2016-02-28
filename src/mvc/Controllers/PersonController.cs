using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace Controllers
{
    public class PersonController : Controller
    {
        private static List<string> people = new List<string> { "Han", "Leia", "Luke" }; 
        
        public object List() 
        {
            return people;
        }
        
        public IActionResult Put([FromBody] string person) 
        {
            if (person == null) {
                return this.HttpBadRequest();
            }
            
            people.Add(person);
            return this.Ok();
        }
    }    
}
