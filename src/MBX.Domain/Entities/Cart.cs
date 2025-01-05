using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Cart : BaseEntity
{
    public Guid? CustomerId { get; set; }
    public string SessionId { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("CustomerId")] public virtual Customer? Customer { get; set; }
    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}