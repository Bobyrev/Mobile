using MediatR;
using Mobile.ApiContracts.Device.Command;
using Mobile.DataAccess.Contexts;
using Mobile.DataAccess.Models;

namespace Mobile.Api.ApplicationLogic.Device.Command
{
    public class CreateDeviceCommandHandler : IRequestHandler<CreateDeviceCommand>
    {
        private readonly MobileWriteContext _mobileWriteContext;

        public CreateDeviceCommandHandler(MobileWriteContext mobileWriteContext)
        {
            _mobileWriteContext = mobileWriteContext;
        }

        public async Task Handle(CreateDeviceCommand request, CancellationToken cancellationToken)
        {
            var device = new Mobile.DataAccess.Models.Device
            {
                CreatedDate = DateTime.Now,
                DeviceCode = Guid.NewGuid(),
                LastModifiedDate = DateTime.Now,
                DeviceModel = request.DeviceModel,
                DeviceName = request.DeviceName,
                IsActivated = request.IsActivated,
            };

            var user = new User
            {
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,
                Devices = new List<DataAccess.Models.Device> { device },
                UserMail = request.UserEmail,
                Settings = new List<DataAccess.Models.Settings>
                {
                    new DataAccess.Models.Settings
                    {
                        CreatedDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                        EnableAutoPayment = false,
                        ShowAdv = false,
                        UseLocation = "Тюмень",
                        ColorScheme = new ColorScheme
                        {
                            LastModifiedDate = DateTime.Now,
                            CreatedDate = DateTime.Now,
                            BackgoundColor = "white",
                            ButtonsColor = "black",
                            TextColor = "red"
                        }
                    }
                }
            };

            await _mobileWriteContext.Users.AddAsync(user, cancellationToken);
            await _mobileWriteContext.SaveChangesAsync(cancellationToken);
        }
    }
}
