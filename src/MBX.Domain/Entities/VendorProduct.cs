using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class VendorProduct : BaseEntity
{
    public Guid VendorId { get; set; }
    public Guid ProductId { get; set; }

    // Navigation properties
    [ForeignKey("VendorId")] public virtual Vendor Vendor { get; set; } = null!;
    [ForeignKey("ProductId")] public virtual Product Product { get; set; } = null!;
}