using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class AdCampaign : BaseEntity
{
    public string Platform { get; set; } = string.Empty;
    public string CampaignName { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime EndDate { get; set; } = DateTime.UtcNow;

    [Column(TypeName = "decimal(18, 2)")] public decimal Budget { get; set; }

    public string TargetAudience { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<AdCampaignResult> AdCampaignResults { get; set; } = new List<AdCampaignResult>();
}