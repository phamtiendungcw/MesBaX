using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities;

public class NewsletterSubscription
{
    [Key] public Guid SubscriptionID { get; set; } = Guid.NewGuid();

    public string Email { get; set; } = string.Empty;
    public DateTime SubscriptionDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; }
}