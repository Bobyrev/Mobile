using MediatR;
using Mobile.ApiContracts.Settings.Query.Models;

namespace Mobile.ApiContracts.Settings.Query
{
    public sealed record GetSettingsQuery : IRequest<SettingsResponseViewModel>
    {
        public string UserMail { get; set; } = null!;
    }
}
