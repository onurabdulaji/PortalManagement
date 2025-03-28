using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalManagement.Domain.Entities;

namespace PortalManagement.Persistence.Configurations;

public class AppUserConfiguration : BaseConfiguration<AppUser>
{
    public override void Configure(EntityTypeBuilder<AppUser> builder)
    {
        base.Configure(builder);
        builder.Ignore(x => x.ID);
        builder.HasOne(x => x.Profile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.Id);
    }
}