using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Review
{
    [Key] public Guid ReviewID { get; set; } = Guid.NewGuid();

    public Guid ProductID { get; set; }
    public Guid CustomerID { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime ReviewDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("ProductID")] public virtual Product Product { get; set; } = null!;

    [ForeignKey("CustomerID")] public virtual Customer Customer { get; set; } = null!;
}