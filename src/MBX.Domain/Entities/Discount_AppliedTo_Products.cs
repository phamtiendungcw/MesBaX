using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Discount_AppliedTo_Products
{
    [Key] public Guid DiscountAppliedToProductsID { get; set; } = Guid.NewGuid();

    public Guid DiscountID { get; set; }
    public Guid ProductID { get; set; }

    // Navigation properties
    [ForeignKey("DiscountID")] public virtual Discount Discount { get; set; } = null!;

    [ForeignKey("ProductID")] public virtual Product Product { get; set; } = null!;
}