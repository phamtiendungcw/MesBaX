using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class OrderDetail
{
    [Key] public Guid OrderDetailID { get; set; } = Guid.NewGuid();

    public Guid OrderID { get; set; }
    public Guid ProductID { get; set; }

    [Column(TypeName = "decimal(18, 2)")] public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")] public decimal Discount { get; set; }

    // Navigation properties
    [ForeignKey("OrderID")] public virtual Order Order { get; set; } = null!;

    [ForeignKey("ProductID")] public virtual Product Product { get; set; } = null!;
}