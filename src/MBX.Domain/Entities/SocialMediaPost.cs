using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class SocialMediaPost
{
    [Key] public Guid PostID { get; set; } = Guid.NewGuid();

    public string Platform { get; set; } = string.Empty;
    public string PostContent { get; set; } = string.Empty;
    public DateTime PostDate { get; set; } = DateTime.UtcNow;
    public string PostURL { get; set; } = string.Empty;
    public Guid? ProductID { get; set; }
    public int Reach { get; set; }
    public int Engagement { get; set; }

    // Navigation properties
    [ForeignKey("ProductID")] public virtual Product? Product { get; set; }
}