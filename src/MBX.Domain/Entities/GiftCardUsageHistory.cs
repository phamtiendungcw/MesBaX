using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class GiftCardUsageHistory : BaseEntity
{
    public Guid GiftCardId { get; set; }
    public Guid OrderId { get; set; }
    [Column(TypeName = "decimal(18, 2)")] public decimal UsedAmount { get; set; }
    public DateTime UsedDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("GiftCardId")] public virtual GiftCard GiftCard { get; set; } = null!;
    [ForeignKey("OrderId")] public virtual Order Order { get; set; } = null!;
}