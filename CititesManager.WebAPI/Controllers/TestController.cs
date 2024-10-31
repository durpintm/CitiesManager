using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CititesManager.WebAPI.Controllers
{
    public class TestController : CustomControllerBase
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World!";
        }

        [HttpGet]
        [Route("helloworld")]
        public string HelloWorld()
        {
            return "Hello World! Attribute Route";
        }
    }
}
