using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.FirstName).HasMaxLength(100);
        builder.Property(c => c.LastName).HasMaxLength(100);
        builder.Property(c => c.Email).HasMaxLength(255).IsRequired();
        builder.Property(c => c.Password).IsRequired();
        builder.Property(c => c.PhoneNumber).HasMaxLength(20);
        builder.Property(c => c.Address).IsRequired(false);
        builder.Property(c => c.City).IsRequired(false);
        builder.Property(c => c.Region).IsRequired(false);
        builder.Property(c => c.PostalCode).IsRequired(false);
        builder.Property(c => c.Country).IsRequired(false);
        builder.Property(c => c.RegistrationDate).IsRequired();
    }
}