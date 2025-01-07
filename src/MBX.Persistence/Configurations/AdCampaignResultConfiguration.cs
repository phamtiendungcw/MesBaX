using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class AdCampaignResultConfiguration : IEntityTypeConfiguration<AdCampaignResult>
{
    public void Configure(EntityTypeBuilder<AdCampaignResult> builder)
    {
        builder.HasKey(acr => acr.Id);
        builder.HasOne(acr => acr.AdCampaign).WithMany(ac => ac.AdCampaignResults).HasForeignKey(acr => acr.CampaignId);
        builder.Property(acr => acr.Impressions).IsRequired();
        builder.Property(acr => acr.Clicks).IsRequired();
        builder.Property(acr => acr.Conversions).IsRequired();
        builder.Property(acr => acr.Cost).HasColumnType("decimal(18, 2)").IsRequired();
        builder.Property(acr => acr.Roas).HasColumnType("decimal(18, 2)").IsRequired(false);
    }
}