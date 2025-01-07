using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class WishlistConfiguration : IEntityTypeConfiguration<Wishlist>
{
    public void Configure(EntityTypeBuilder<Wishlist> builder)
    {
        builder.HasKey(w => w.Id);
        builder.HasOne(w => w.Customer).WithMany(c => c.Wishlists).HasForeignKey(w => w.CustomerId);
        builder.HasOne(w => w.Product).WithMany(p => p.Wishlists).HasForeignKey(w => w.ProductId);
        builder.Property(w => w.CreateDate).IsRequired();
    }
}