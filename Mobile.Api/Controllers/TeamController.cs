using MediatR;
using Microsoft.AspNetCore.Mvc;
using Mobile.ApiContracts.Team.Query;

namespace Mobile.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TeamController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetUsers([FromQuery] GetTeamUsersQuery query, CancellationToken cancellationToken)
        {
            var data = await _mediator.Send(query, cancellationToken);

            return Ok(data);
        }
    }
}
