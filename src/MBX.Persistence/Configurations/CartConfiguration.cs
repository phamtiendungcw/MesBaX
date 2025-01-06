using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasKey(c => c.Id);
        builder.HasOne(c => c.Customer).WithMany(cu => cu.Carts).HasForeignKey(c => c.CustomerId);
        builder.Property(c => c.SessionId).IsRequired(false);
        builder.Property(c => c.CreatedDate).IsRequired();
    }
}