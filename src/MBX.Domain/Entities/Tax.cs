using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Tax : BaseEntity
{
    public string TaxName { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18, 2)")] public decimal TaxRate { get; set; }
    public string TaxType { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<ProductTax> ProductTaxes { get; set; } = new List<ProductTax>();
}