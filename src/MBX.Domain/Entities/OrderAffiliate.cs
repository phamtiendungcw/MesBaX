using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class OrderAffiliate
{
    [Key] public Guid OrderAffiliateID { get; set; } = Guid.NewGuid();

    public Guid OrderID { get; set; }
    public Guid AffiliateID { get; set; }

    // Navigation properties
    [ForeignKey("OrderID")] public virtual Order Order { get; set; } = null!;

    [ForeignKey("AffiliateID")] public virtual Affiliate Affiliate { get; set; } = null!;
}