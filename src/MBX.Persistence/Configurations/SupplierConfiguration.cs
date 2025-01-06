using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.SupplierName).HasMaxLength(255).IsRequired();
        builder.Property(s => s.ContactName).HasMaxLength(255);
        builder.Property(s => s.ContactEmail).HasMaxLength(255);
        builder.Property(s => s.ContactPhone).HasMaxLength(20);
        builder.Property(s => s.Address).IsRequired(false);
    }
}