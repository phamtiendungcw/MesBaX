using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
{
    public void Configure(EntityTypeBuilder<Vendor> builder)
    {
        builder.HasKey(v => v.Id);
        builder.Property(v => v.VendorName).IsRequired();
        builder.Property(v => v.Email).IsRequired();
        builder.Property(v => v.Description).IsRequired(false);
        builder.Property(v => v.PhoneNumber).IsRequired(false);
        builder.Property(v => v.Address).IsRequired(false);
        builder.Property(v => v.Rating).HasColumnType("decimal(18, 2)").IsRequired();
        builder.Property(v => v.CreatedDate).IsRequired();
        builder.Property(v => v.UpdatedDate).IsRequired();
    }
}