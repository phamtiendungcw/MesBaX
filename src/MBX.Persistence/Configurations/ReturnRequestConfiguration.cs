using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class ReturnRequestConfiguration : IEntityTypeConfiguration<ReturnRequest>
{
    public void Configure(EntityTypeBuilder<ReturnRequest> builder)
    {
        builder.HasKey(rr => rr.Id);
        builder.HasOne(rr => rr.Order).WithMany(o => o.ReturnRequests).HasForeignKey(rr => rr.OrderId);
        builder.HasOne(rr => rr.Product).WithMany(p => p.ReturnRequests).HasForeignKey(rr => rr.ProductId);
        builder.Property(rr => rr.Quantity).IsRequired();
        builder.Property(rr => rr.Reason).IsRequired();
        builder.Property(rr => rr.RequestedAction).IsRequired();
        builder.Property(rr => rr.RequestDate).IsRequired();
        builder.Property(rr => rr.Status).IsRequired();
    }
}