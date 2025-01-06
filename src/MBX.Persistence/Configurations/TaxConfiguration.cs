using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class TaxConfiguration : IEntityTypeConfiguration<Tax>
{
    public void Configure(EntityTypeBuilder<Tax> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.TaxName).IsRequired();
        builder.Property(t => t.TaxRate).HasColumnType("decimal(18, 2)").IsRequired();
        builder.Property(t => t.TaxType).IsRequired();
        builder.Property(t => t.Country).IsRequired();
        builder.Property(t => t.Region).IsRequired();
    }
}