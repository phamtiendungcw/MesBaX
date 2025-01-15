using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
        builder.HasOne(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);
        builder.Property(u => u.Username).HasMaxLength(50).IsRequired();
        builder.Property(u => u.Password).IsRequired();
        builder.Property(u => u.Email).HasMaxLength(255).IsRequired();
        builder.Property(u => u.FirstName).HasMaxLength(100);
        builder.Property(u => u.LastName).HasMaxLength(100);
        builder.Property(u => u.IsActive).IsRequired();
        builder.Property(u => u.CreatedDate).IsRequired();
    }
}