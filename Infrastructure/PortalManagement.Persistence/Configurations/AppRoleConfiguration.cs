using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalManagement.Domain.Entities;

namespace PortalManagement.Persistence.Configurations;

public class AppRoleConfiguration : BaseConfiguration<AppRole>
{
    public override void Configure(EntityTypeBuilder<AppRole> builder)
    {
        base.Configure(builder);
    }
}