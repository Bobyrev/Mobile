using Microsoft.AspNetCore.Mvc;

namespace Mobile.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class DeviceController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> All() 
        {
            return Ok();
        }
    }
}
