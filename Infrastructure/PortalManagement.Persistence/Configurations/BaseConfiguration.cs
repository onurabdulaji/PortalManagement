using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PortalManagement.Domain.Entities.IBase;

namespace PortalManagement.Persistence.Configurations;

public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.Property(q => q.CreatedDate).IsRequired();
    }
}
