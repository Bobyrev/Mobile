using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Configurations;

namespace Mobile.DataAccess.Models
{
    /// <summary>
    /// Администратор
    /// </summary>
    [EntityTypeConfiguration(typeof(AdminConfigurations))]
    public class Admin : User
    {
        /// <summary>
        /// Команда
        /// </summary>
        public virtual Team Team { get; set; } = null!;
    }
}
