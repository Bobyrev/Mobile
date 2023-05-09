using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Configurations;

namespace Mobile.DataAccess.Models
{
    /// <summary>
    /// Настройки приложения
    /// </summary>
    [EntityTypeConfiguration(typeof(SettingsConfigurations))]
    public class Settings : BaseModel<long>
    {
        /// <summary>
        /// Идентификатор цветовой схемы
        /// </summary>
        public long ColorSchemeId { get; set; }

        /// <summary>
        /// Цветовая схема
        /// </summary>
        public virtual ColorScheme ColorScheme { get; set; } = null!;

        /// <summary>
        /// Местоположение
        /// </summary>
        public string UseLocation { get; set; } = null!;

        /// <summary>
        ///  Показывать рекламу
        /// </summary>
        public bool ShowAdv { get; set; }

        /// <summary>
        /// Включен автоплатеж
        /// </summary>
        public bool EnableAutoPayment { get; set; }

        /// <summary>
        /// Пользователи
        /// </summary>
        public virtual List<User> Users { get; set; } = null!;
    }
}
