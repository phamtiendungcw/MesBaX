using MBX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MBX.Persistence.Configurations;

public class NewsletterSubscriptionConfiguration : IEntityTypeConfiguration<NewsletterSubscription>
{
    public void Configure(EntityTypeBuilder<NewsletterSubscription> builder)
    {
        builder.HasKey(ns => ns.Id);
        builder.Property(ns => ns.Email).IsRequired();
        builder.Property(ns => ns.SubscriptionDate).IsRequired();
        builder.Property(ns => ns.IsActive).IsRequired();
    }
}