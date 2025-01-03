using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Tax
{
    [Key] public Guid TaxID { get; set; } = Guid.NewGuid();

    public string TaxName { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18, 2)")] public decimal TaxRate { get; set; }

    public string TaxType { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<ProductTax> ProductTaxes { get; set; } = new List<ProductTax>();
}