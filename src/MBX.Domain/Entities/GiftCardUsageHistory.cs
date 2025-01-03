using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class GiftCardUsageHistory
{
    [Key] public Guid UsageID { get; set; } = Guid.NewGuid();

    public Guid GiftCardID { get; set; }
    public Guid OrderID { get; set; }

    [Column(TypeName = "decimal(18, 2)")] public decimal UsedAmount { get; set; }

    public DateTime UsedDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("GiftCardID")] public virtual GiftCard GiftCard { get; set; } = null!;

    [ForeignKey("OrderID")] public virtual Order Order { get; set; } = null!;
}