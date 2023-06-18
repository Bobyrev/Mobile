namespace Mobile.ApiContracts.Team.Query.Models
{
    public class UserTeamViewModel
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Роль
        /// </summary>
        public string Role { get; set; } = null!;
    }
}
