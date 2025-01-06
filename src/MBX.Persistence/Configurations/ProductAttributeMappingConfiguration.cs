using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class ProductAttributeMappingConfiguration : IEntityTypeConfiguration<ProductAttributeMapping>
{
    public void Configure(EntityTypeBuilder<ProductAttributeMapping> builder)
    {
        builder.HasKey(pam => pam.Id);
        builder.HasOne(pam => pam.Product).WithMany(p => p.ProductAttributeMappings).HasForeignKey(pam => pam.ProductId);
        builder.HasOne(pam => pam.ProductAttributeValue).WithMany(pav => pav.ProductAttributeMappings).HasForeignKey(pam => pam.AttributeValueId);
    }
}