using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class Review : BaseEntity
{
    public Guid ProductId { get; set; }
    public Guid CustomerId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime ReviewDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("ProductId")] public virtual Product Product { get; set; } = null!;

    [ForeignKey("CustomerId")] public virtual Customer Customer { get; set; } = null!;
}