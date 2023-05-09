using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Configurations;

namespace Mobile.DataAccess.Models
{
    /// <summary>
    /// Цветовая схема
    /// </summary>
    [EntityTypeConfiguration(typeof(ColorSchemeConfigurations))]
    public class ColorScheme : BaseModel<long>
    {
        /// <summary>
        /// Цвет фона
        /// </summary>
        public string BackgoundColor { get; set; } = null!;
        
        /// <summary>
        /// Цвет кнопок
        /// </summary>
        public string ButtonsColor { get; set; } = null!;
        
        /// <summary>
        /// Цвет текста
        /// </summary>
        public string TextColor { get; set; } = null!;

        /// <summary>
        /// Настройки
        /// </summary>
        public virtual List<Settings> Settings { get; set; } = null!;

    }
}
