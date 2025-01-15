using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class ProductAttributeValueConfiguration : IEntityTypeConfiguration<ProductAttributeValue>
{
    public void Configure(EntityTypeBuilder<ProductAttributeValue> builder)
    {
        builder.HasKey(pav => pav.Id);
        builder.HasOne(pav => pav.ProductAttribute).WithMany(pa => pa.ProductAttributeValues).HasForeignKey(pav => pav.AttributeId);
        builder.Property(pav => pav.Value).HasMaxLength(255).IsRequired();
    }
}