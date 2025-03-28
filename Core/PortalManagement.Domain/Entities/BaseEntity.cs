using PortalManagement.Domain.Entities.IBase;
using PortalManagement.Domain.Enums;

namespace PortalManagement.Domain.Entities;

public abstract class BaseEntity : IBaseEntity
{
    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
        Status = DataStatus.Created;
    }
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public DateTime DeletedDate { get; set; }
    public DataStatus Status { get; set; }
}
