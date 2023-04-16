using MediatR;

namespace Mobile.ApiContracts.Device.Command
{
    public class DeleteDeviceCommand : IRequest
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

    }
}
