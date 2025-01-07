using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class CustomerCustomerGroupMappingConfiguration : IEntityTypeConfiguration<CustomerCustomerGroupMapping>
{
    public void Configure(EntityTypeBuilder<CustomerCustomerGroupMapping> builder)
    {
        builder.HasKey(ccgm => ccgm.Id);
        builder.HasOne(ccgm => ccgm.Customer).WithMany(c => c.CustomerCustomerGroupMappings).HasForeignKey(ccgm => ccgm.CustomerId);
        builder.HasOne(ccgm => ccgm.CustomerGroup).WithMany(cg => cg.CustomerCustomerGroupMappings).HasForeignKey(ccgm => ccgm.GroupId);
    }
}