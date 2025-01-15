using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class CustomerGroupConfiguration : IEntityTypeConfiguration<CustomerGroup>
{
    public void Configure(EntityTypeBuilder<CustomerGroup> builder)
    {
        builder.HasKey(cg => cg.Id);
        builder.Property(cg => cg.GroupName).IsRequired();
        builder.Property(cg => cg.GroupDescription).IsRequired(false);
    }
}