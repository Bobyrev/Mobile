namespace Mobile.ApiContracts.Device.Query.Models
{
    public class DeviceViewModel
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Дата создания записи
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Дата последнего изменения записи
        /// </summary>
        public DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// Модель телефона
        /// </summary>
        public string DeviceModel { get; set; }

        /// <summary>
        /// Имя телефона
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// Идентификатор регистрации
        /// </summary>
        public Guid DeviceCode { get; set; }

        /// <summary>
        /// Признак активации приложения
        /// </summary>
        public bool IsActivated { get; set; }
    }
}
