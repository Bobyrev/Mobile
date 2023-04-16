using MediatR;

namespace Mobile.ApiContracts.Device.Command
{
    public class UpdateDeviceCommand : IRequest
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Модель телефона
        /// </summary>
        public string DeviceModel { get; set; }

        /// <summary>
        /// Имя телефона
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// Электронная почта пользователя
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// Признак активации приложения
        /// </summary>
        public bool IsActivated { get; set; }
    }
}
