using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class InventoryTransactionConfiguration : IEntityTypeConfiguration<InventoryTransaction>
{
    public void Configure(EntityTypeBuilder<InventoryTransaction> builder)
    {
        builder.HasKey(it => it.Id);
        builder.HasOne(it => it.Product).WithMany(p => p.InventoryTransactions).HasForeignKey(it => it.ProductId);
        builder.Property(it => it.TransactionType).HasMaxLength(50).IsRequired();
        builder.Property(it => it.Quantity).IsRequired();
        builder.Property(it => it.TransactionDate).IsRequired();
        builder.Property(it => it.Reference).IsRequired(false);
    }
}