using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.ProductName).HasMaxLength(255).IsRequired();
        builder.Property(p => p.ProductDescription).IsRequired(false);
        builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
        builder.HasOne(p => p.Supplier).WithMany(s => s.Products).HasForeignKey(p => p.SupplierId);
        builder.Property(p => p.UnitPrice).HasColumnType("decimal(18, 2)");
        builder.Property(p => p.CostPrice).HasColumnType("decimal(18, 2)");
        builder.Property(p => p.Sku).HasMaxLength(50);
        builder.Property(p => p.ProductImage).IsRequired(false);
    }
}