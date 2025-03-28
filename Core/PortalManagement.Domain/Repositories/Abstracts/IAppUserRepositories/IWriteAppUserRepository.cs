using PortalManagement.Domain.Entities;
using PortalManagement.Domain.Repositories.IGeneric;

namespace PortalManagement.Domain.Repositories.Abstracts.IAppUserRepositories;

public interface IWriteAppUserRepository : IGenericWriteRepository<AppUser>
{
    Task CreateUser(AppUser appUser);
}