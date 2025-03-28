using Microsoft.Extensions.DependencyInjection;
using PortalManagement.Application.IManagement.UserService;

namespace PortalManagement.Application.Extensions;

public static class ServiceManagerExtensions
{
    public static void AddServiceAndManagersExtensions(this IServiceCollection services)
    {
        // Fathers
        services.AddScoped<IUserManagementService, UserManagementService>();

        // Helpers
        services.AddScoped<IUserHelperManagementService, UserHelperManagementService>();

    }
}
