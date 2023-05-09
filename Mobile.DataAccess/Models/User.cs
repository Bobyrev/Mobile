using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Configurations;

namespace Mobile.DataAccess.Models
{
    /// <summary>
    /// Пользователь
    /// </summary>
    [EntityTypeConfiguration(typeof(UserConfigurations))]
    public class User : BaseModel<long>
    {
        /// <summary>
        /// Электронная почта
        /// </summary>
        public string UserMail { get; set; } = null!;

        /// <summary>
        /// Настройки
        /// </summary>
        public virtual List<Settings> Settings { get; set; } = null!;

        /// <summary>
        /// Девайсы пользоваеля
        /// </summary>
        public virtual List<Device> Devices { get; set; } = null!;

    }
}
