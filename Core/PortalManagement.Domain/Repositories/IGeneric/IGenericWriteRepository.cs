using PortalManagement.Domain.Entities.IBase;

namespace PortalManagement.Domain.Repositories.IGeneric;

public interface IGenericWriteRepository<T> where T : class, IBaseEntity, new()
{
    Task AddAsync(T entity);
    Task AddRangeAsync(IList<T> entities);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
}
