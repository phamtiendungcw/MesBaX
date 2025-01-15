using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class VendorProductConfiguration : IEntityTypeConfiguration<VendorProduct>
{
    public void Configure(EntityTypeBuilder<VendorProduct> builder)
    {
        builder.HasKey(vp => vp.Id);
        builder.HasOne(vp => vp.Vendor).WithMany(v => v.VendorProducts).HasForeignKey(vp => vp.VendorId);
        builder.HasOne(vp => vp.Product).WithMany(p => p.VendorProducts).HasForeignKey(vp => vp.ProductId);
    }
}