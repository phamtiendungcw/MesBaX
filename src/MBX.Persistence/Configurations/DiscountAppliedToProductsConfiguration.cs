using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class DiscountAppliedToProductsConfiguration : IEntityTypeConfiguration<DiscountAppliedToProducts>
{
    public void Configure(EntityTypeBuilder<DiscountAppliedToProducts> builder)
    {
        builder.HasKey(dap => dap.Id);
        builder.HasOne(dap => dap.Discount).WithMany(d => d.DiscountAppliedToProducts).HasForeignKey(dap => dap.DiscountId);
        builder.HasOne(dap => dap.Product).WithMany(p => p.DiscountAppliedToProducts).HasForeignKey(dap => dap.ProductId);
    }
}