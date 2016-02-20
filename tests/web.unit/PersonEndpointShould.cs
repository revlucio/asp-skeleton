using System.Net;
using Microsoft.AspNet.TestHost;
using Xunit;

namespace Web.Unit
{
    public class PersonEndpointShould
    {
        [Fact]
        public async void ReturnBadRequestWhenPutIsEmpty()
        {
            var server = new TestServer(TestServer.CreateBuilder().UseStartup<Mvc.Startup>());
            var client = server.CreateClient();
            
            var response = await client.PutAsync("/person", null);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}