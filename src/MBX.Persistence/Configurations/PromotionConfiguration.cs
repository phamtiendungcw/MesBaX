using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
{
    public void Configure(EntityTypeBuilder<Promotion> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Code).IsRequired();
        builder.Property(p => p.DiscountType).IsRequired();
        builder.Property(p => p.DiscountValue).HasColumnType("decimal(18, 2)").IsRequired();
        builder.Property(p => p.StartDate).IsRequired();
        builder.Property(p => p.EndDate).IsRequired();
        builder.Property(p => p.MinimumOrderValue).HasColumnType("decimal(18, 2)");
        builder.Property(p => p.UsageLimit).IsRequired();
        builder.Property(p => p.UsedCount).IsRequired();
        builder.Property(p => p.IsActive).IsRequired();
    }
}