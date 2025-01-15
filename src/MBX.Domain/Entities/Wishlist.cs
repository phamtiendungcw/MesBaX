using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class Wishlist : BaseEntity
{
    public Guid CustomerId { get; set; }
    public Guid ProductId { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("CustomerId")] public virtual Customer Customer { get; set; } = null!;
    [ForeignKey("ProductId")] public virtual Product Product { get; set; } = null!;
}