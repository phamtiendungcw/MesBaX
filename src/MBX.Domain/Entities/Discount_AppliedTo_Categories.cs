using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class DiscountAppliedToCategories : BaseEntity
{
    public Guid DiscountId { get; set; }
    public Guid CategoryId { get; set; }

    // Navigation properties
    [ForeignKey("DiscountId")] public virtual Discount Discount { get; set; } = null!;
    [ForeignKey("CategoryId")] public virtual Category Category { get; set; } = null!;
}