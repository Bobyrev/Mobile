using MediatR;
using Mobile.ApiContracts.Device.Query.Models;

namespace Mobile.ApiContracts.Device.Query
{
    public class GetAllDeviceQuery : IRequest<IEnumerable<DeviceViewModel>>
    {
    }
}
