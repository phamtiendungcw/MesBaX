using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class ShippingMethodConfiguration : IEntityTypeConfiguration<ShippingMethod>
{
    public void Configure(EntityTypeBuilder<ShippingMethod> builder)
    {
        builder.HasKey(sm => sm.Id);
        builder.Property(sm => sm.Name).IsRequired();
        builder.Property(sm => sm.Description).IsRequired(false);
        builder.Property(sm => sm.Cost).HasColumnType("decimal(18, 2)");
    }
}