using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Configurations;

namespace Mobile.DataAccess.Models
{
    /// <summary>
    /// Команда
    /// </summary>
    [EntityTypeConfiguration(typeof(TeamConfigurations))]
    public class Team : BaseNamedModel<long>
    {
        /// <summary>
        /// Игроки
        /// </summary>
        public virtual IList<Player> Players { get; set; } = null!;

        /// <summary>
        /// Тренера
        /// </summary>
        public virtual IList<Coach> Coaches { get; set; } = null!;

        /// <summary>
        /// Администраторы
        /// </summary>
        public virtual IList<Admin> Admins { get; set; } = null!;

        /// <summary>
        /// Все пользователи
        /// </summary>
        public IList<User> Users 
        {
            get
            {
                List<User> result = new();

                result.AddRange(Players);
                result.AddRange(Coaches);
                result.AddRange(Admins);

                return result;
            }
        }
    }
}
