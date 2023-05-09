using MediatR;
using Microsoft.EntityFrameworkCore;
using Mobile.ApiContracts.Settings.Query;
using Mobile.ApiContracts.Settings.Query.Models;
using Mobile.DataAccess.Contexts;

namespace Mobile.Api.ApplicationLogic.Settings.Query
{
    public class GetSettingsQueryHandler : IRequestHandler<GetSettingsQuery, SettingsResponseViewModel>
    {
        private readonly MobileReadContext _mobileReadContext;

        public GetSettingsQueryHandler(MobileReadContext mobileReadContext)
        {
            _mobileReadContext = mobileReadContext;
        }

        public async Task<SettingsResponseViewModel> Handle(GetSettingsQuery request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.UserMail)) 
            {
                return new SettingsResponseViewModel
                {
                    IsRegistered = false,
                    Message = "Пользователь не найден",
                    Settings = null
                };
            }

            var user = await _mobileReadContext.Users.FirstAsync(x => x.UserMail == request.UserMail);
            var settings = user.Settings;
            var colorScheme = settings?.ColorScheme;

            return new SettingsResponseViewModel
            {
                IsRegistered = true,
                Message = "",
                Settings = new SettingViewModel 
                {
                    BackgoundColor = colorScheme?.BackgoundColor,
                    ButtonsColor = colorScheme?.ButtonsColor,
                    TextColor = colorScheme?.TextColor,
                    EnableAutoPayment = settings?.EnableAutoPayment ?? false,
                    ShowAdv = settings?.ShowAdv ?? false,
                    UseLocation = settings?.UseLocation
                }
            };
        }
    }
}
