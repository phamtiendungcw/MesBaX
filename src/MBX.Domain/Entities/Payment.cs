using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Payment : BaseEntity
{
    public Guid OrderId { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18, 2)")] public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
    public string Status { get; set; } = string.Empty;
    public string TransactionId { get; set; } = string.Empty;

    // Navigation properties
    [ForeignKey("OrderId")] public virtual Order Order { get; set; } = null!;
}