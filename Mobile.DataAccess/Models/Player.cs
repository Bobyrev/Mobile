using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Configurations;

namespace Mobile.DataAccess.Models
{
    /// <summary>
    /// Игрок
    /// </summary>
    [EntityTypeConfiguration(typeof(PlayerConfigurations))]
    public class Player : User
    {
        /// <summary>
        /// Команда
        /// </summary>
        public virtual Team Team { get; set; } = null!;

        /// <summary>
        /// Позиция
        /// </summary>
        public virtual Place Place { get; set; } = null!;

    }
}
