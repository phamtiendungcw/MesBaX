using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class AdCampaignResult
{
    [Key] public Guid ResultID { get; set; } = Guid.NewGuid();

    public Guid CampaignID { get; set; }
    public int Impressions { get; set; }
    public int Clicks { get; set; }
    public int Conversions { get; set; }

    [Column(TypeName = "decimal(18, 2)")] public decimal Cost { get; set; }

    [Column(TypeName = "decimal(18, 2)")] public decimal? ROAS { get; set; }

    // Navigation properties
    [ForeignKey("CampaignID")] public virtual AdCampaign AdCampaign { get; set; } = null!;
}