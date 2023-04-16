using MediatR;
using Microsoft.EntityFrameworkCore;
using Mobile.ApiContracts.Device.Query;
using Mobile.ApiContracts.Device.Query.Models;
using Mobile.DataAccess.Contexts;

namespace Mobile.Api.ApplicationLogic.Device.Query
{
    public class GetAllDeviceQueryHandler : IRequestHandler<GetAllDeviceQuery, IEnumerable<DeviceViewModel>>
    {
        private readonly MobileReadContext _mobileReadContext;

        public GetAllDeviceQueryHandler(MobileReadContext mobileReadContext)
        {
            _mobileReadContext = mobileReadContext;
        }

        public async Task<IEnumerable<DeviceViewModel>> Handle(GetAllDeviceQuery request, CancellationToken cancellationToken)
        {
            var models = await _mobileReadContext.Devices.ToListAsync(cancellationToken);

            return models.Select(model => new DeviceViewModel
            {
                Id = model.Id,
                CreatedDate = model.CreatedDate,
                DeviceCode = model.DeviceCode,
                DeviceModel = model.DeviceModel,
                DeviceName = model.DeviceName,
                IsActivated = model.IsActivated,
                LastModifiedDate = model.LastModifiedDate,
                UserEmail = model.UserEmail,
            });
        }
    }
}
