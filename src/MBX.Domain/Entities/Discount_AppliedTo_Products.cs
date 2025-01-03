using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class DiscountAppliedToProducts : BaseEntity
{
    public Guid DiscountId { get; set; }
    public Guid ProductId { get; set; }

    // Navigation properties
    [ForeignKey("DiscountId")] public virtual Discount Discount { get; set; } = null!;

    [ForeignKey("ProductId")] public virtual Product Product { get; set; } = null!;
}