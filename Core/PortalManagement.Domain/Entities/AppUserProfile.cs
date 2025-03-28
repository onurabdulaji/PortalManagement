namespace PortalManagement.Domain.Entities;

public class AppUserProfile : BaseEntity
{
    public AppUserProfile()
    {
    }
    public AppUserProfile(string firstname, string lastname, string nationalid, DateTime birthday, string email)
    {
        FirstName = firstname;
        LastName = lastname;
        NationalIdentityNumber = nationalid;
        DateOfBirth = birthday;
        Email = email;
    }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? NationalIdentityNumber { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Email { get; set; }
    // Relational Props
    public virtual AppUser? AppUser { get; set; }
}
