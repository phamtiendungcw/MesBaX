using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class ProductTax : BaseEntity
{
    public Guid ProductId { get; set; }
    public Guid TaxId { get; set; }

    // Navigation properties
    [ForeignKey("ProductId")] public virtual Product Product { get; set; } = null!;
    [ForeignKey("TaxId")] public virtual Tax Tax { get; set; } = null!;
}