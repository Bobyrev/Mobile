using MediatR;
using Microsoft.EntityFrameworkCore;
using Mobile.ApiContracts.Device.Command;
using Mobile.DataAccess.Contexts;

namespace Mobile.Api.ApplicationLogic.Device.Command
{
    public class UpdateDeviceCommandHandler : IRequestHandler<UpdateDeviceCommand>
    {
        private readonly MobileWriteContext _mobileWriteContext;

        public UpdateDeviceCommandHandler(MobileWriteContext mobileWriteContext)
        {
            _mobileWriteContext = mobileWriteContext;
        }

        public async Task Handle(UpdateDeviceCommand request, CancellationToken cancellationToken)
        {
            var model = await _mobileWriteContext.Devices.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (model is null)
                return;

            model.LastModifiedDate = DateTime.Now;
            model.DeviceModel = request.DeviceModel;
            model.DeviceName = request.DeviceName;
            model.IsActivated = request.IsActivated;

            await _mobileWriteContext.SaveChangesAsync(cancellationToken);
        }
    }
}
