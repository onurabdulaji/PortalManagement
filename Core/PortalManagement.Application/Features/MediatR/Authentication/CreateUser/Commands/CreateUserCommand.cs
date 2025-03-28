using MediatR;
using PortalManagement.DTO.DTOS.UserDtos;

namespace PortalManagement.Application.Features.MediatR.Authentication.CreateUser.Commands;

public class CreateUserCommand : IRequest<Unit>
{
    public CreateUserDto CreateUserDto { get; set; }

    // Constructor to initialize CreateUserDto
    public CreateUserCommand(CreateUserDto createUserDto)
    {
        CreateUserDto = createUserDto;
    }
}
