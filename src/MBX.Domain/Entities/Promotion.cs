using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Promotion
{
    [Key] public Guid PromotionID { get; set; } = Guid.NewGuid();

    public string Code { get; set; } = string.Empty;
    public string DiscountType { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18, 2)")] public decimal DiscountValue { get; set; }

    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime EndDate { get; set; } = DateTime.UtcNow;

    [Column(TypeName = "decimal(18, 2)")] public decimal MinimumOrderValue { get; set; }

    public int UsageLimit { get; set; }
    public int UsedCount { get; set; }
    public bool IsActive { get; set; }
}