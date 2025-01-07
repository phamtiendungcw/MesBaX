using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class AffiliateConfiguration : IEntityTypeConfiguration<Affiliate>
{
    public void Configure(EntityTypeBuilder<Affiliate> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.FirstName).IsRequired();
        builder.Property(a => a.LastName).IsRequired();
        builder.Property(a => a.Email).IsRequired();
        builder.Property(a => a.PhoneNumber).IsRequired(false);
        builder.Property(a => a.Address).IsRequired(false);
        builder.Property(a => a.CommissionRate).HasColumnType("decimal(18, 2)").IsRequired();
        builder.Property(a => a.AffiliateUrl).IsRequired();
    }
}