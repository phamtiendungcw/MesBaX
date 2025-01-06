using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class BlogCommentConfiguration : IEntityTypeConfiguration<BlogComment>
{
    public void Configure(EntityTypeBuilder<BlogComment> builder)
    {
        builder.HasKey(bc => bc.Id);
        builder.HasOne(bc => bc.BlogPost).WithMany(bp => bp.BlogComments).HasForeignKey(bc => bc.PostId);
        builder.HasOne(bc => bc.Customer).WithMany(c => c.BlogComments).HasForeignKey(bc => bc.CustomerId);
        builder.Property(bc => bc.Name).IsRequired(false);
        builder.Property(bc => bc.Email).IsRequired(false);
        builder.Property(bc => bc.CommentText).IsRequired();
        builder.Property(bc => bc.CommentDate).IsRequired();
        builder.Property(bc => bc.IsApproved).IsRequired();
    }
}