using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class CartItem
{
    [Key] public Guid CartItemID { get; set; } = Guid.NewGuid();

    public Guid CartID { get; set; }
    public Guid ProductID { get; set; }
    public int Quantity { get; set; }
    public DateTime AddedDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("CartID")] public virtual Cart Cart { get; set; } = null!;

    [ForeignKey("ProductID")] public virtual Product Product { get; set; } = null!;
}