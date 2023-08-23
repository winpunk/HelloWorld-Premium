using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_Premium.Controllers
{
    [ApiController]
    [Route("api/")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [Route("CreateHelloWorld")]
        [HttpPost]
        public IActionResult Post()
        {
            return NoContent();
        }

        [Route("GetHelloWorld")]
        [HttpGet]
        public IActionResult Get(string helloWorldId)
        {
            return NoContent();
        }

        [Route("DeleteHelloWorld")]
        [HttpDelete]
        public IActionResult Delete(string helloWorldId)
        {
            return NoContent();
        }
    }
}