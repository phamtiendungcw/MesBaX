using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
{
    public void Configure(EntityTypeBuilder<CustomerAddress> builder)
    {
        builder.HasKey(ca => ca.Id);
        builder.HasOne(ca => ca.Customer).WithMany(c => c.CustomerAddresses).HasForeignKey(ca => ca.CustomerId);
        builder.Property(ca => ca.AddressType).IsRequired();
        builder.Property(ca => ca.AddressLine1).IsRequired();
        builder.Property(ca => ca.AddressLine2).IsRequired(false);
        builder.Property(ca => ca.City).IsRequired();
        builder.Property(ca => ca.Region).IsRequired();
        builder.Property(ca => ca.PostalCode).IsRequired();
        builder.Property(ca => ca.Country).IsRequired();
        builder.Property(ca => ca.IsDefault).IsRequired();
    }
}