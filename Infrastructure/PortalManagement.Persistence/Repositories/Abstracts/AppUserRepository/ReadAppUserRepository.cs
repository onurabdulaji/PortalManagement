using PortalManagement.Domain.Entities;
using PortalManagement.Domain.Repositories.Abstracts.IAppUserRepositories;
using PortalManagement.Persistence.Context.Data;
using PortalManagement.Persistence.Repositories.GenericRepositories;

namespace PortalManagement.Persistence.Repositories.Abstracts.AppUserRepository;

public class ReadAppUserRepository : GenericReadRepository<AppUser>, IReadAppUserRepository
{
    public ReadAppUserRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
