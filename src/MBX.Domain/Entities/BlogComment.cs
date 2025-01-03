using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class BlogComment
{
    [Key] public Guid CommentID { get; set; } = Guid.NewGuid();

    public Guid PostID { get; set; }
    public Guid? CustomerID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string CommentText { get; set; } = string.Empty;
    public DateTime CommentDate { get; set; } = DateTime.UtcNow;
    public bool IsApproved { get; set; }

    // Navigation properties
    [ForeignKey("PostID")] public virtual BlogPost BlogPost { get; set; } = null!;

    [ForeignKey("CustomerID")] public virtual Customer? Customer { get; set; }
}