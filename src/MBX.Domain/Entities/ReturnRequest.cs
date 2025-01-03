using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class ReturnRequest : BaseEntity
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public string Reason { get; set; } = string.Empty;
    public string RequestedAction { get; set; } = string.Empty;
    public DateTime RequestDate { get; set; } = DateTime.UtcNow;
    public string Status { get; set; } = string.Empty;

    // Navigation properties
    [ForeignKey("OrderId")] public virtual Order Order { get; set; } = null!;

    [ForeignKey("ProductId")] public virtual Product Product { get; set; } = null!;
}