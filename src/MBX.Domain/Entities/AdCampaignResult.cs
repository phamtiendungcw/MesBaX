using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class AdCampaignResult : BaseEntity
{
    public Guid CampaignId { get; set; }
    public int Impressions { get; set; }
    public int Clicks { get; set; }
    public int Conversions { get; set; }
    [Column(TypeName = "decimal(18, 2)")] public decimal Cost { get; set; }
    [Column(TypeName = "decimal(18, 2)")] public decimal? Roas { get; set; }

    // Navigation properties
    [ForeignKey("CampaignId")] public virtual AdCampaign AdCampaign { get; set; } = null!;
}