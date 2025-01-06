using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class UserCustomerMappingConfiguration : IEntityTypeConfiguration<UserCustomerMapping>
{
    public void Configure(EntityTypeBuilder<UserCustomerMapping> builder)
    {
        builder.HasKey(ucm => ucm.Id);
        builder.HasOne(ucm => ucm.User).WithMany(u => u.UserCustomerMappings).HasForeignKey(ucm => ucm.UserId);
        builder.HasOne(ucm => ucm.Customer).WithMany(c => c.UserCustomerMappings).HasForeignKey(ucm => ucm.CustomerId);
    }
}