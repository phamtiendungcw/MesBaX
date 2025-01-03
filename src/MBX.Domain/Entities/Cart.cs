using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Cart
{
    [Key] public Guid CartID { get; set; } = Guid.NewGuid();

    public Guid? CustomerID { get; set; }
    public string SessionID { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("CustomerID")] public virtual Customer? Customer { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}