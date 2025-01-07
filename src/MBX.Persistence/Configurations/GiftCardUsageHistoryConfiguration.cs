using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class GiftCardUsageHistoryConfiguration : IEntityTypeConfiguration<GiftCardUsageHistory>
{
    public void Configure(EntityTypeBuilder<GiftCardUsageHistory> builder)
    {
        builder.HasKey(gcuh => gcuh.Id);
        builder.HasOne(gcuh => gcuh.GiftCard).WithMany(gc => gc.GiftCardUsageHistories).HasForeignKey(gcuh => gcuh.GiftCardId);
        builder.HasOne(gcuh => gcuh.Order).WithMany(o => o.GiftCardUsageHistories).HasForeignKey(gcuh => gcuh.OrderId);
        builder.Property(gcuh => gcuh.UsedAmount).HasColumnType("decimal(18, 2)").IsRequired();
        builder.Property(gcuh => gcuh.UsedDate).IsRequired();
    }
}