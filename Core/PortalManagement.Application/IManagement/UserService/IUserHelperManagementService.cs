using Microsoft.AspNetCore.Identity;
using PortalManagement.Domain.Entities;

namespace PortalManagement.Application.IManagement.UserService;

public interface IUserHelperManagementService
{
    void ValidateUserCreateInput(string username, string email);
    Task ValidateEmailUniquenessAsync(UserManager<AppUser> userManager, string email);

}
