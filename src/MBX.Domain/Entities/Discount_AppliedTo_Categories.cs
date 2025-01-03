using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Discount_AppliedTo_Categories
{
    [Key] public Guid DiscountAppliedToCategoriesID { get; set; } = Guid.NewGuid();

    public Guid DiscountID { get; set; }
    public Guid CategoryID { get; set; }

    // Navigation properties
    [ForeignKey("DiscountID")] public virtual Discount Discount { get; set; } = null!;

    [ForeignKey("CategoryID")] public virtual Category Category { get; set; } = null!;
}