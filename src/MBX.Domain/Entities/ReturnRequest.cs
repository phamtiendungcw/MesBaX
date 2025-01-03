using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class ReturnRequest
{
    [Key] public Guid ReturnRequestID { get; set; } = Guid.NewGuid();

    public Guid OrderID { get; set; }
    public Guid ProductID { get; set; }
    public int Quantity { get; set; }
    public string Reason { get; set; } = string.Empty;
    public string RequestedAction { get; set; } = string.Empty;
    public DateTime RequestDate { get; set; } = DateTime.UtcNow;
    public string Status { get; set; } = string.Empty;

    // Navigation properties
    [ForeignKey("OrderID")] public virtual Order Order { get; set; } = null!;

    [ForeignKey("ProductID")] public virtual Product Product { get; set; } = null!;
}