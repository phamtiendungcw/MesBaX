using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class BlogComment : BaseEntity
{
    public Guid PostId { get; set; }
    public Guid? CustomerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string CommentText { get; set; } = string.Empty;
    public DateTime CommentDate { get; set; } = DateTime.UtcNow;
    public bool IsApproved { get; set; }

    // Navigation properties
    [ForeignKey("PostId")] public virtual BlogPost BlogPost { get; set; } = null!;

    [ForeignKey("CustomerId")] public virtual Customer? Customer { get; set; }
}