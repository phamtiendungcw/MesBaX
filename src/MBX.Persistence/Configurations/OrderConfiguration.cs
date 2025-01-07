using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);
        builder.HasOne(o => o.Customer).WithMany(c => c.Orders).HasForeignKey(o => o.CustomerId);
        builder.Property(o => o.OrderDate).IsRequired();
        builder.Property(o => o.ShippedDate).IsRequired(false);
        builder.Property(o => o.ShipAddress).IsRequired(false);
        builder.Property(o => o.ShipCity).IsRequired(false);
        builder.Property(o => o.ShipRegion).IsRequired(false);
        builder.Property(o => o.ShipPostalCode).IsRequired(false);
        builder.Property(o => o.ShipCountry).IsRequired(false);
        builder.Property(o => o.ShippingFee).HasColumnType("decimal(18, 2)");
        builder.Property(o => o.OrderStatus).HasMaxLength(50).IsRequired();
        builder.Property(o => o.PaymentMethod).HasMaxLength(50);
        builder.Property(o => o.PaymentStatus).IsRequired(false);
        builder.Property(o => o.TransactionId).IsRequired(false);
        builder.Property(o => o.Note).IsRequired(false);
    }
}