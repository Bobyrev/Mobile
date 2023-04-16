using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Configuration;

namespace Mobile.DataAccess.Models
{
    /// <summary>
    /// Информация о смартфоне
    /// </summary>
    [EntityTypeConfiguration(typeof(DeviceConfigurations))]
    public class Device : BaseModel<long>
    {
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
        /// Электронная почта пользователя
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// Признак активации приложения
        /// </summary>
        public bool IsActivated { get; set; }
    }
}
