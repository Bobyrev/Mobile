using MediatR;
using Mobile.ApiContracts.Device.Command;
using Mobile.DataAccess.Contexts;

namespace Mobile.Api.ApplicationLogic.Device.Command
{
    public class CreateDeviceCommandHandler : IRequestHandler<CreateDeviceCommand>
    {
        private readonly MobileWriteContext _mobileWriteContext;

        public CreateDeviceCommandHandler(MobileWriteContext mobileWriteContext)
        {
            _mobileWriteContext = mobileWriteContext;
        }

        public async Task Handle(CreateDeviceCommand request, CancellationToken cancellationToken)
        {
            var device = new Mobile.DataAccess.Models.Device
            {
                CreatedDate = DateTime.Now,
                DeviceCode = Guid.NewGuid(),
                LastModifiedDate = DateTime.Now,
                DeviceModel = request.DeviceModel,
                DeviceName = request.DeviceName,
                IsActivated = request.IsActivated,
            };

            await _mobileWriteContext.Devices.AddAsync(device, cancellationToken);
            await _mobileWriteContext.SaveChangesAsync(cancellationToken);
        }
    }
}
