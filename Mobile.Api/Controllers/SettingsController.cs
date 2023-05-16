using MediatR;
using Microsoft.AspNetCore.Mvc;
using Mobile.ApiContracts.Settings.Query;

namespace Mobile.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class SettingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SettingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetSettings([FromQuery] string userMail, CancellationToken cancellationToken)
        {
            var data = await _mediator.Send(new GetSettingsQuery { UserMail = userMail }, cancellationToken);

            return Ok(data);
        }
    }
}
