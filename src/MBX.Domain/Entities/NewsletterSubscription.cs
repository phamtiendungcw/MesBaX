using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class NewsletterSubscription : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    public DateTime SubscriptionDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; }
}