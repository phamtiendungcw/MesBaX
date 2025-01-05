using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class GiftCard : BaseEntity
{
    public string GiftCardCode { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18, 2)")] public decimal InitialValue { get; set; }
    [Column(TypeName = "decimal(18, 2)")] public decimal RemainingValue { get; set; }
    public DateTime ExpirationDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; }
    public string RecipientName { get; set; } = string.Empty;
    public string RecipientEmail { get; set; } = string.Empty;
    public string SenderName { get; set; } = string.Empty;
    public string SenderEmail { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<GiftCardUsageHistory> GiftCardUsageHistories { get; set; } = new List<GiftCardUsageHistory>();
}