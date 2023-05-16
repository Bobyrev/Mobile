using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Configurations;

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
        public string DeviceModel { get; set; } = null!;

        /// <summary>
        /// Имя телефона
        /// </summary>
        public string DeviceName { get; set; } = null!;

        /// <summary>
        /// Идентификатор регистрации
        /// </summary>
        public Guid DeviceCode { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public virtual User User { get; set; } = null!;

        /// <summary>
        /// Признак активации приложения
        /// </summary>
        public bool IsActivated { get; set; }
    }
}
