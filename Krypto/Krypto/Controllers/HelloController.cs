using Microsoft.AspNetCore.Mvc;
using Krypto.Services;
using Krypto.Interface;

namespace Krypto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly INewService _newService;

        public HelloController(INewService newService)
        {
            _newService = newService;
        }

        [HttpGet]
        public IActionResult GetMessage()
        {
            var message = _newService.GetMessage();
            return Ok(message);
        }
    }
}
