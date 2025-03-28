using Microsoft.AspNetCore.Identity;
using PortalManagement.Domain.Entities.IBase;
using PortalManagement.Domain.Enums;

namespace PortalManagement.Domain.Entities;

public class AppUser : IdentityUser<Guid>, IBaseEntity
{
    public AppUser()
    {
        CreatedDate = DateTime.UtcNow;
        Status = DataStatus.Created;
    }
    public Guid ID { get; set; }
    public string? ConfirmationCode { get; set; }
    public DateTime? ConfirmationCodeExpiry { get; set; }
    public bool? IsActive { get; set; } = false;
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public DataStatus? Status { get; set; }

    // Foreign Key & Navigation Property
    public virtual AppUserProfile Profile { get; set; }
}
