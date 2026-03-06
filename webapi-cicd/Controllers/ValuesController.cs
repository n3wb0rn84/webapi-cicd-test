using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webapi_cicd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{Hello}")]
        public IActionResult sayHello()
        {
            return Ok("Bonjour 42");
        }

    }
}
