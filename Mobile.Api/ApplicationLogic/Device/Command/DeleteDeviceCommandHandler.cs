using MediatR;
using Microsoft.EntityFrameworkCore;
using Mobile.ApiContracts.Device.Command;
using Mobile.DataAccess.Contexts;

namespace Mobile.Api.ApplicationLogic.Device.Command
{
    public class DeleteDeviceCommandHandler : IRequestHandler<DeleteDeviceCommand>
    {
        private readonly MobileWriteContext _mobileWriteContext;

        public DeleteDeviceCommandHandler(MobileWriteContext mobileWriteContext)
        {
            _mobileWriteContext = mobileWriteContext;
        }

        public async Task Handle(DeleteDeviceCommand request, CancellationToken cancellationToken)
        {
            var model = await _mobileWriteContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (model is null)
                return;

            _mobileWriteContext.Users.Remove(model);
            
            await _mobileWriteContext.SaveChangesAsync(cancellationToken);
        }
    }
}
