using PortalManagement.Domain.Entities;
using PortalManagement.Domain.Repositories.IGeneric;

namespace PortalManagement.Domain.Repositories.Abstracts.IAppUserProfileRepositories;

public interface IWriteAppUserProfileRepository : IGenericWriteRepository<AppUserProfile>
{
}