using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class OrderDetail : BaseEntity
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }

    [Column(TypeName = "decimal(18, 2)")] public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")] public decimal Discount { get; set; }

    // Navigation properties
    [ForeignKey("OrderId")] public virtual Order Order { get; set; } = null!;

    [ForeignKey("ProductId")] public virtual Product Product { get; set; } = null!;
}