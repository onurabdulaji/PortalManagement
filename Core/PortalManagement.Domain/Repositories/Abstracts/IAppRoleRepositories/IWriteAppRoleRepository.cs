using PortalManagement.Domain.Entities;
using PortalManagement.Domain.Repositories.IGeneric;

namespace PortalManagement.Domain.Repositories.Abstracts.IAppRoleRepositories;

public interface IWriteAppRoleRepository : IGenericWriteRepository<AppRole>
{
}