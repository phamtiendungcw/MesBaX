using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class SocialMediaPost : BaseEntity
{
    public string Platform { get; set; } = string.Empty;
    public string PostContent { get; set; } = string.Empty;
    public DateTime PostDate { get; set; } = DateTime.UtcNow;
    public string PostUrl { get; set; } = string.Empty;
    public Guid? ProductId { get; set; }
    public int Reach { get; set; }
    public int Engagement { get; set; }

    // Navigation properties
    [ForeignKey("ProductId")] public virtual Product? Product { get; set; }
}