using MediatR;
using Microsoft.EntityFrameworkCore;
using Mobile.ApiContracts.Device.Query;
using Mobile.ApiContracts.Device.Query.Models;
using Mobile.DataAccess.Contexts;

namespace Mobile.Api.ApplicationLogic.Device.Query
{
    public class GetDeviceByCodeQueryHandler : IRequestHandler<GetDeviceByCodeQuery, DeviceViewModel>
    {
        private readonly MobileReadContext _mobileReadContext;

        public GetDeviceByCodeQueryHandler(MobileReadContext mobileReadContext)
        {
            _mobileReadContext = mobileReadContext;
        }

        public async Task<DeviceViewModel> Handle(GetDeviceByCodeQuery request, CancellationToken cancellationToken)
        {
            var model = await _mobileReadContext.Devices.FirstOrDefaultAsync(x => x.DeviceCode == request.DeviceCode, cancellationToken);

            if (model is null)
                return null;

            return new DeviceViewModel
            {
                Id = model.Id,
                CreatedDate = model.CreatedDate,
                DeviceCode = model.DeviceCode,
                DeviceModel = model.DeviceModel,
                DeviceName = model.DeviceName,
                IsActivated = model.IsActivated,
                LastModifiedDate = model.LastModifiedDate,
            };
        }
    }
}
