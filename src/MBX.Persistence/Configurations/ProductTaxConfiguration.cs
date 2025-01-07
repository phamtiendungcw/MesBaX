using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class ProductTaxConfiguration : IEntityTypeConfiguration<ProductTax>
{
    public void Configure(EntityTypeBuilder<ProductTax> builder)
    {
        builder.HasKey(pt => pt.Id);
        builder.HasOne(pt => pt.Product).WithMany(p => p.ProductTaxes).HasForeignKey(pt => pt.ProductId);
        builder.HasOne(pt => pt.Tax).WithMany(t => t.ProductTaxes).HasForeignKey(pt => pt.TaxId);
    }
}