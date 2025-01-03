using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class ProductAttributeMapping : BaseEntity
{
    public Guid ProductId { get; set; }
    public Guid AttributeValueId { get; set; }

    // Navigation properties
    [ForeignKey("ProductId")] public virtual Product Product { get; set; } = null!;

    [ForeignKey("AttributeValueId")] public virtual ProductAttributeValue ProductAttributeValue { get; set; } = null!;
}