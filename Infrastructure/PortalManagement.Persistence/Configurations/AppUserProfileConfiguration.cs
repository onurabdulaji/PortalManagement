using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalManagement.Domain.Entities;

namespace PortalManagement.Persistence.Configurations;

public class AppUserProfileConfiguration : BaseConfiguration<AppUserProfile>
{
    public override void Configure(EntityTypeBuilder<AppUserProfile> builder)
    {
        base.Configure(builder);
    }
}