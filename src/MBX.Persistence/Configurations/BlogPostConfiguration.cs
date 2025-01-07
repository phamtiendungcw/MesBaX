using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
{
    public void Configure(EntityTypeBuilder<BlogPost> builder)
    {
        builder.HasKey(bp => bp.Id);
        builder.Property(bp => bp.Title).IsRequired();
        builder.Property(bp => bp.Content).IsRequired();
        builder.HasOne(bp => bp.Author).WithMany(u => u.BlogPosts).HasForeignKey(bp => bp.AuthorId);
        builder.Property(bp => bp.PublishDate).IsRequired();
        builder.Property(bp => bp.Tags).IsRequired(false);
        builder.Property(bp => bp.MetaKeywords).IsRequired(false);
        builder.Property(bp => bp.MetaDescription).IsRequired(false);
    }
}