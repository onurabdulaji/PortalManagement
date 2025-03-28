using PortalManagement.Domain.Entities.IBase;
using PortalManagement.Domain.Repositories.Abstracts.IAppUserRepositories;
using PortalManagement.Domain.Repositories.IGeneric;

namespace PortalManagement.Domain.Repositories.IUnitOfWorks;

public interface IUnitOfWork : IDisposable, IAsyncDisposable
{
    IGenericReadRepository<T> GetGenericReadRepository<T>() where T : class, IBaseEntity, new();
    IGenericWriteRepository<T> GetGenericWriteRepository<T>() where T : class, IBaseEntity, new();
    Task<int> SaveAsync();
    IReadAppUserRepository TGetReadAppUserRepository { get; }
    IWriteAppUserRepository TGetWriteAppUserRepository { get; }
}
