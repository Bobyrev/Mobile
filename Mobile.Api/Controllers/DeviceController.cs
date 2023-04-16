using MediatR;
using Microsoft.AspNetCore.Mvc;
using Mobile.ApiContracts.Device.Command;
using Mobile.ApiContracts.Device.Query;

namespace Mobile.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class DeviceController : ControllerBase
    {

        private readonly IMediator _mediator;

        public DeviceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> All(CancellationToken cancellationToken) 
        {
            var data = await _mediator.Send(new GetAllDeviceQuery(), cancellationToken);
            return Ok(data);
        }

        [HttpGet("{code:guid}")]
        public async Task<IActionResult> One(Guid code, CancellationToken cancellationToken)
        {
            var data = await _mediator.Send(new GetDeviceByCodeQuery { DeviceCode = code}, cancellationToken);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDeviceCommand command, CancellationToken cancellationToken)
        {
            await _mediator.Send(command, cancellationToken);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateDeviceCommand command, CancellationToken cancellationToken)
        {
            await _mediator.Send(command, cancellationToken);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteDeviceCommand command, CancellationToken cancellationToken)
        {
            await _mediator.Send(command, cancellationToken);

            return Ok();
        }

    }
}
