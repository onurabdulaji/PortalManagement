using PortalManagement.Domain.Enums;

namespace PortalManagement.Domain.Entities.IBase;

public interface IBaseEntity
{
    public Guid Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public DataStatus? Status { get; set; }
}
