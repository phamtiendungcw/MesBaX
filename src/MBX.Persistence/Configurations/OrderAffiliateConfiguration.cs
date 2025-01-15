using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class OrderAffiliateConfiguration : IEntityTypeConfiguration<OrderAffiliate>
{
    public void Configure(EntityTypeBuilder<OrderAffiliate> builder)
    {
        builder.HasKey(oa => oa.Id);
        builder.HasOne(oa => oa.Order).WithMany(o => o.OrderAffiliates).HasForeignKey(oa => oa.OrderId);
        builder.HasOne(oa => oa.Affiliate).WithMany(a => a.OrderAffiliates).HasForeignKey(oa => oa.AffiliateId);
    }
}