using MediatR;
using PortalManagement.Application.IManagement.UserService;

namespace PortalManagement.Application.Features.MediatR.Authentication.CreateUser.Commands;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Unit>
{
    private readonly IUserManagementService _userManagementService;

    public CreateUserCommandHandler(IUserManagementService userManagementService)
    {
        _userManagementService = userManagementService;
    }

    public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        await _userManagementService.CreateUserAsync(request.CreateUserDto);

        return Unit.Value;
    }
}
