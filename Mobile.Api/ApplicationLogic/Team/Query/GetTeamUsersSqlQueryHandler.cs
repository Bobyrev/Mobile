using MediatR;
using Mobile.ApiContracts.Team.Query.Models;
using Mobile.ApiContracts.Team.Query;
using Mobile.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Mobile.Api.ApplicationLogic.Team.Query
{
    public class GetTeamUsersSqlQueryHandler : IRequestHandler<GetTeamUsersSqlQuery, IEnumerable<UserTeamViewModel>>
    {
        private readonly MobileReadContext _mobileReadContext;

        public GetTeamUsersSqlQueryHandler(MobileReadContext mobileReadContext)
        {
            _mobileReadContext = mobileReadContext;
        }

        public async Task<IEnumerable<UserTeamViewModel>> Handle(GetTeamUsersSqlQuery request, CancellationToken cancellationToken)
        {
            var connection = _mobileReadContext.Database.GetDbConnection();

            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"select * from dbo.GetUsersByTeamId({request.Id})";
            var reader = await command.ExecuteReaderAsync();

            var result = new List<UserTeamViewModel>();
            while (reader.Read())
            {
                result.Add(new UserTeamViewModel
                {
                    Name = reader.GetString("name"),
                    Role = reader.GetString("role")
                });
            }

            connection.Close();
            return result;
        }
    }
}
