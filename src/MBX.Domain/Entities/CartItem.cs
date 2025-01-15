using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class CartItem : BaseEntity
{
    public Guid CartId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public DateTime AddedDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("CartId")] public virtual Cart Cart { get; set; } = null!;
    [ForeignKey("ProductId")] public virtual Product Product { get; set; } = null!;
}