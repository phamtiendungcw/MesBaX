using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class ProductTax
{
    [Key] public Guid ProductTaxID { get; set; } = Guid.NewGuid();

    public Guid ProductID { get; set; }
    public Guid TaxID { get; set; }

    // Navigation properties
    [ForeignKey("ProductID")] public virtual Product Product { get; set; } = null!;

    [ForeignKey("TaxID")] public virtual Tax Tax { get; set; } = null!;
}