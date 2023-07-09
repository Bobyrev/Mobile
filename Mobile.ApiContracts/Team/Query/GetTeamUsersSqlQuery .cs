using MediatR;
using Mobile.ApiContracts.Team.Query.Models;

namespace Mobile.ApiContracts.Team.Query
{
    /// <summary>
    /// Получение пользователей одной команды
    /// </summary>
    public class GetTeamUsersSqlQuery : IRequest<IEnumerable<UserTeamViewModel>>
    {
        /// <summary>
        /// Идентификатор группы
        /// </summary>
        public long Id { get; set; }

    }
}
