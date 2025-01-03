using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Discount
{
    [Key] public Guid DiscountID { get; set; } = Guid.NewGuid();

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
    public virtual ICollection<Discount_AppliedTo_Products> DiscountAppliedToProducts { get; set; } = new List<Discount_AppliedTo_Products>();

    public virtual ICollection<Discount_AppliedTo_Categories> DiscountAppliedToCategories { get; set; } = new List<Discount_AppliedTo_Categories>();
}