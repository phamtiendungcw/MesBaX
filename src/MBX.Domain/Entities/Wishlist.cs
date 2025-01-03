using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Wishlist
{
    [Key] public Guid WishlistID { get; set; } = Guid.NewGuid();

    public Guid CustomerID { get; set; }
    public Guid ProductID { get; set; }

    public DateTime CreateDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("CustomerID")] public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("ProductID")] public virtual Product Product { get; set; } = null!;
}