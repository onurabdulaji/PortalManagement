using PortalManagement.Domain.Entities;
using PortalManagement.Domain.Repositories.Abstracts.IAppUserRepositories;
using PortalManagement.Persistence.Context.Data;
using PortalManagement.Persistence.Repositories.GenericRepositories;

namespace PortalManagement.Persistence.Repositories.Abstracts.AppUserRepository;

public class WriteAppUserRepository : GenericWriteRepository<AppUser>, IWriteAppUserRepository
{
    public WriteAppUserRepository(AppDbContext appDbContext) : base(appDbContext)
    {

    }

    public async Task CreateUser(AppUser appUser)
    {
        await _context.AddAsync(appUser);
    }
}