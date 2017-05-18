
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ConferenceDemo.Web.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        [Route("insecure")]
        [HttpGet]
        public HttpResponseMessage NotSecure()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Yay!");
        }

        [Route("HelloWorld")]
        [Authorize]
        [HttpGet]
        public HttpResponseMessage HelloWorld()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Hello");
        }
    }
}