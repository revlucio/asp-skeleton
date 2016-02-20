using Microsoft.AspNet.TestHost;
using Xunit;

namespace Web.Unit
{
    public class HelloWorldControllerShould
    {
        [Fact]
        public async void ReturnHelloWorld()
        {
            var server = new TestServer(TestServer.CreateBuilder().UseStartup<Mvc.Startup>());
            var client = server.CreateClient();
            
            var response = await client.GetAsync("/");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            
            Assert.Equal("Hello, world from MVC!", responseString);
        }
    }
}