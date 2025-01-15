using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasOne(p => p.Order).WithMany(o => o.Payments).HasForeignKey(p => p.OrderId);
        builder.Property(p => p.PaymentMethod).IsRequired();
        builder.Property(p => p.Amount).HasColumnType("decimal(18, 2)").IsRequired();
        builder.Property(p => p.PaymentDate).IsRequired();
        builder.Property(p => p.Status).IsRequired();
        builder.Property(p => p.TransactionId).IsRequired(false);
    }
}