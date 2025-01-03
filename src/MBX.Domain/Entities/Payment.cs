using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Payment
{
    [Key] public Guid PaymentID { get; set; } = Guid.NewGuid();

    public Guid OrderID { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18, 2)")] public decimal Amount { get; set; }

    public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
    public string Status { get; set; } = string.Empty;
    public string TransactionID { get; set; } = string.Empty;

    // Navigation properties
    [ForeignKey("OrderID")] public virtual Order Order { get; set; } = null!;
}