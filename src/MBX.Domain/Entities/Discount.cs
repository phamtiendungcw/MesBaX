using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class Discount : BaseEntity
{
    public string DiscountName { get; set; } = string.Empty;
    public string DiscountType { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18, 2)")] public decimal DiscountValue { get; set; }
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime EndDate { get; set; } = DateTime.UtcNow;
    public bool RequiresCoupon { get; set; }
    public string CouponCode { get; set; } = string.Empty;
    public int MinimumQuantity { get; set; }
    [Column(TypeName = "decimal(18, 2)")] public decimal? MaximumDiscountAmount { get; set; }

    // Navigation properties
    public virtual ICollection<DiscountAppliedToProducts> DiscountAppliedToProducts { get; set; } = new List<DiscountAppliedToProducts>();

    public virtual ICollection<DiscountAppliedToCategories> DiscountAppliedToCategories { get; set; } = new List<DiscountAppliedToCategories>();
}