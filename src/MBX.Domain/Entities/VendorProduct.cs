using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class VendorProduct
{
    [Key] public Guid VendorProductID { get; set; } = Guid.NewGuid();

    public Guid VendorID { get; set; }
    public Guid ProductID { get; set; }

    // Navigation properties
    [ForeignKey("VendorID")] public virtual Vendor Vendor { get; set; } = null!;

    [ForeignKey("ProductID")] public virtual Product Product { get; set; } = null!;
}