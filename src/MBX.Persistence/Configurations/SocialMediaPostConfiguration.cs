using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class SocialMediaPostConfiguration : IEntityTypeConfiguration<SocialMediaPost>
{
    public void Configure(EntityTypeBuilder<SocialMediaPost> builder)
    {
        builder.HasKey(smp => smp.Id);
        builder.Property(smp => smp.Platform).IsRequired();
        builder.Property(smp => smp.PostContent).IsRequired();
        builder.Property(smp => smp.PostDate).IsRequired();
        builder.Property(smp => smp.PostUrl).IsRequired();
        builder.HasOne(smp => smp.Product).WithMany(p => p.SocialMediaPosts).HasForeignKey(smp => smp.ProductId);
        builder.Property(smp => smp.Reach).IsRequired();
        builder.Property(smp => smp.Engagement).IsRequired();
    }
}