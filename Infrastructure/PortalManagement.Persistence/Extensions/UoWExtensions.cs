using Microsoft.Extensions.DependencyInjection;
using PortalManagement.Domain.Repositories.IUnitOfWorks;
using PortalManagement.Persistence.Repositories.UnitOfWorks;

namespace PortalManagement.Persistence.Extensions;

public static class UoWExtensions
{
    public static void AddUnitOfWorkExtension(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
