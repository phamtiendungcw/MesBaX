using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class DiscountAppliedToCategoriesConfiguration : IEntityTypeConfiguration<DiscountAppliedToCategories>
{
    public void Configure(EntityTypeBuilder<DiscountAppliedToCategories> builder)
    {
        builder.HasKey(dac => dac.Id);
        builder.HasOne(dac => dac.Discount).WithMany(d => d.DiscountAppliedToCategories).HasForeignKey(dac => dac.DiscountId);
        builder.HasOne(dac => dac.Category).WithMany(c => c.DiscountAppliedToCategories).HasForeignKey(dac => dac.CategoryId);
    }
}