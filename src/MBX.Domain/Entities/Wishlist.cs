using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class WishList : BaseEntity
{
    public Guid CustomerId { get; set; }
    public Guid ProductId { get; set; }

    public DateTime CreateDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("CustomerId")] public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("ProductId")] public virtual Product Product { get; set; } = null!;
}