using System.ComponentModel.DataAnnotations;
using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class Supplier : BaseEntity
{
    [Required] [MaxLength(255)] public string SupplierName { get; set; } = string.Empty;

    [MaxLength(255)] public string ContactName { get; set; } = string.Empty;

    [MaxLength(255)] public string ContactEmail { get; set; } = string.Empty;

    [MaxLength(20)] public string ContactPhone { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}