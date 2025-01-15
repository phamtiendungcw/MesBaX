using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class GiftCardConfiguration : IEntityTypeConfiguration<GiftCard>
{
    public void Configure(EntityTypeBuilder<GiftCard> builder)
    {
        builder.HasKey(gc => gc.Id);
        builder.Property(gc => gc.GiftCardCode).IsRequired();
        builder.Property(gc => gc.InitialValue).HasColumnType("decimal(18, 2)").IsRequired();
        builder.Property(gc => gc.RemainingValue).HasColumnType("decimal(18, 2)").IsRequired();
        builder.Property(gc => gc.ExpirationDate).IsRequired();
        builder.Property(gc => gc.IsActive).IsRequired();
        builder.Property(gc => gc.RecipientName).IsRequired(false);
        builder.Property(gc => gc.RecipientEmail).IsRequired(false);
        builder.Property(gc => gc.SenderName).IsRequired(false);
        builder.Property(gc => gc.SenderEmail).IsRequired(false);
        builder.Property(gc => gc.Message).IsRequired(false);
    }
}