using MediatR;
using Microsoft.EntityFrameworkCore;
using Mobile.ApiContracts.Team.Query;
using Mobile.ApiContracts.Team.Query.Models;
using Mobile.DataAccess.Contexts;
using Mobile.DataAccess.Models;
using System.Linq.Expressions;

namespace Mobile.Api.ApplicationLogic.Team.Query
{
    public class GetTeamUsersQueryHandler : IRequestHandler<GetTeamUsersQuery, IEnumerable<UserViewModel>>
    {
        private readonly MobileReadContext _mobileReadContext;

        public GetTeamUsersQueryHandler(MobileReadContext mobileReadContext)
        {
            _mobileReadContext = mobileReadContext;
        }

        public async Task<IEnumerable<UserViewModel>> Handle(GetTeamUsersQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<DataAccess.Models.Team, bool>> predicate = request switch
            {
                { Id: not null } => x => x.Id == request.Id,
                { Name: not null and not "" } => x => x.Name == request.Name,
                _ => throw new ArgumentException()
            };

            var team = await _mobileReadContext.Teams.FirstOrDefaultAsync(predicate);

            if (team is null)
                return Enumerable.Empty<UserViewModel>();

            return team.Users.Select(x => new UserViewModel 
            {
                UserMail = x.UserMail
            });
        }
    }
}
