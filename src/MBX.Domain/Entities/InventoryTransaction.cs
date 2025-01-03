using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class InventoryTransaction
{
    [Key] public Guid TransactionID { get; set; } = Guid.NewGuid();

    public Guid ProductID { get; set; }

    [Required][MaxLength(50)] public string TransactionType { get; set; } = string.Empty;

    public int Quantity { get; set; }
    public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
    public string Reference { get; set; } = string.Empty;

    // Navigation properties
    [ForeignKey("ProductID")] public virtual Product Product { get; set; } = null!;
}