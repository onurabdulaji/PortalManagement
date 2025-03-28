using Microsoft.Extensions.DependencyInjection;
using PortalManagement.Domain.Repositories.Abstracts.IAppUserRepositories;
using PortalManagement.Persistence.Repositories.Abstracts.AppUserRepository;

namespace PortalManagement.Persistence.Extensions;

public static class RepositoriesExtensions
{
    public static void AddRepositoriesExtension(this IServiceCollection services)
    {
        services.AddScoped<IReadAppUserRepository, ReadAppUserRepository>();
        services.AddScoped<IWriteAppUserRepository, WriteAppUserRepository>();

    }
}
