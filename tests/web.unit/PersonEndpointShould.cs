using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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
        
        [Fact]
        public async void ReturnOkWhenPutIsName()
        {
            var server = new TestServer(TestServer.CreateBuilder().UseStartup<Mvc.Startup>());
            var client = server.CreateClient();
            
            var message = new HttpRequestMessage();
            message.Content = new StringContent("Lando");
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            message.Method = HttpMethod.Put;
            message.RequestUri = new Uri("http://localhost/person");
            
            var response = await client.SendAsync(message);
            // var response = await client.PutAsync("/person", new StringContent("Lando"));

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}