using Microsoft.AspNetCore.Identity;
using PortalManagement.Domain.Entities;

namespace PortalManagement.Application.IManagement.UserService;

public class UserHelperManagementService : IUserHelperManagementService
{
    public async Task ValidateEmailUniquenessAsync(UserManager<AppUser> userManager, string email)
    {
        var existingUser = await userManager.FindByEmailAsync(email);
        if (existingUser != null)
        {
            throw new ArgumentException("Email is already registered.");
        }
    }

    public void ValidateUserCreateInput(string username, string email)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
        {
            throw new ArgumentException("Username and email are required.");
        }
    }
}
