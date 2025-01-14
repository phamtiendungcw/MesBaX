using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class OrderAffiliate : BaseEntity
{
    public Guid OrderId { get; set; }
    public Guid AffiliateId { get; set; }

    // Navigation properties
    [ForeignKey("OrderId")] public virtual Order Order { get; set; } = null!;
    [ForeignKey("AffiliateId")] public virtual Affiliate Affiliate { get; set; } = null!;
}