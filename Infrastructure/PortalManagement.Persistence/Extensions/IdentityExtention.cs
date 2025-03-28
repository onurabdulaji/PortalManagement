using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PortalManagement.Domain.Entities;
using PortalManagement.Persistence.Context.Data;

namespace PortalManagement.Persistence.Extensions;

public static class IdentityExtention
{
    public static void AddIdentityExtensions(this IServiceCollection services)
    {
        services.AddIdentity<AppUser, AppRole>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider)
            .AddEntityFrameworkStores<AppDbContext>();

        services.AddIdentityCore<AppUser>(options =>
        {
            options.SignIn.RequireConfirmedEmail = true;
        })
            .AddEntityFrameworkStores<AppDbContext>();
    }
}
