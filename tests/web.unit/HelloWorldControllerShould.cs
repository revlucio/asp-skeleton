using Controllers;
using Xunit;

namespace Web.Unit
{
    public class HelloWorldControllerShould
    {
        [Fact]
        public void Test()
        {
            var response = new HelloWorldController().Get();
            
            Assert.Equal("Hello, world from MVC!", response);
        }
    }
}