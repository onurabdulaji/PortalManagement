using Microsoft.AspNetCore.Identity;
using PortalManagement.Domain.Entities.IBase;
using PortalManagement.Domain.Enums;

namespace PortalManagement.Domain.Entities;

public class AppRole : IdentityRole<Guid>, IBaseEntity
{
    public AppRole()
    {
        CreatedDate = DateTime.UtcNow;
        Status = DataStatus.Created;
    }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public DataStatus? Status { get; set; }
}

