using Microsoft.Extensions.DependencyInjection;
using PortalManagement.Domain.Repositories.IGeneric;
using PortalManagement.Persistence.Repositories.GenericRepositories;

namespace PortalManagement.Persistence.Extensions;

public static class GenericExtensions
{
    public static void AddGenericPatternExtension(this IServiceCollection services)
    {
        services.AddScoped(typeof(IGenericReadRepository<>), typeof(GenericReadRepository<>));
        services.AddScoped(typeof(IGenericWriteRepository<>), typeof(GenericWriteRepository<>));
    }
}