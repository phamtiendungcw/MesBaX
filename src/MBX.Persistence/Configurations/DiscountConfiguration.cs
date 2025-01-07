using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        builder.HasKey(d => d.Id);
        builder.Property(d => d.DiscountName).IsRequired();
        builder.Property(d => d.DiscountType).IsRequired();
        builder.Property(d => d.DiscountValue).HasColumnType("decimal(18, 2)").IsRequired();
        builder.Property(d => d.StartDate).IsRequired();
        builder.Property(d => d.EndDate).IsRequired();
        builder.Property(d => d.RequiresCoupon).IsRequired();
        builder.Property(d => d.CouponCode).IsRequired(false);
        builder.Property(d => d.MinimumQuantity).IsRequired();
        builder.Property(d => d.MaximumDiscountAmount).HasColumnType("decimal(18, 2)").IsRequired(false);
    }
}