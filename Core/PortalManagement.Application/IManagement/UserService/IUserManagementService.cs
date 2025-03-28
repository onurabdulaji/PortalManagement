using PortalManagement.DTO.DTOS.UserDtos;

namespace PortalManagement.Application.IManagement.UserService;

public interface IUserManagementService
{
    Task CreateUserAsync(CreateUserDto createUserDto);
}
