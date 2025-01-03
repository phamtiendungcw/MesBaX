using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class BlogPost
{
    [Key] public Guid PostID { get; set; } = Guid.NewGuid();

    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public Guid AuthorID { get; set; }
    public DateTime PublishDate { get; set; } = DateTime.UtcNow;
    public string Tags { get; set; } = string.Empty;
    public string MetaKeywords { get; set; } = string.Empty;
    public string MetaDescription { get; set; } = string.Empty;

    // Navigation properties
    [ForeignKey("AuthorID")] public virtual User Author { get; set; } = null!;

    public virtual ICollection<BlogComment> BlogComments { get; set; } = new List<BlogComment>();
}