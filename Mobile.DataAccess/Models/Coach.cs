using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Configurations;

namespace Mobile.DataAccess.Models
{
    /// <summary>
    /// Тренер
    /// </summary>
    [EntityTypeConfiguration(typeof(CoachConfigurations))]
    public class Coach : User
    {
        /// <summary>
        /// Команда
        /// </summary>
        public virtual Team Team { get; set; } = null!;

        /// <summary>
        /// Должность
        /// </summary>
        public virtual Position Position { get; set; } = null!;

    }
}
