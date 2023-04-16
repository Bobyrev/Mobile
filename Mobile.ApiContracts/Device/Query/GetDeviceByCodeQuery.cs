using MediatR;
using Mobile.ApiContracts.Device.Query.Models;

namespace Mobile.ApiContracts.Device.Query
{
    public class GetDeviceByCodeQuery : IRequest<DeviceViewModel>
    {
        /// <summary>
        /// Идентификатор регистрации
        /// </summary>
        public Guid DeviceCode { get; set; }
    }
}
