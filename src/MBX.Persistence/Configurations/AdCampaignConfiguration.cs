using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class AdCampaignConfiguration : IEntityTypeConfiguration<AdCampaign>
{
    public void Configure(EntityTypeBuilder<AdCampaign> builder)
    {
        builder.HasKey(ac => ac.Id);
        builder.Property(ac => ac.Platform).IsRequired();
        builder.Property(ac => ac.CampaignName).IsRequired();
        builder.Property(ac => ac.StartDate).IsRequired();
        builder.Property(ac => ac.EndDate).IsRequired();
        builder.Property(ac => ac.Budget).HasColumnType("decimal(18, 2)").IsRequired();
        builder.Property(p => p.TargetAudience).IsRequired(false);
    }
}