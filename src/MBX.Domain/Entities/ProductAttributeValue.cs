using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class ProductAttributeValue : BaseEntity
{
    public Guid AttributeId { get; set; }
    [Required][MaxLength(255)] public string Value { get; set; } = string.Empty;

    // Navigation properties
    [ForeignKey("AttributeId")] public virtual ProductAttribute ProductAttribute { get; set; } = null!;

    public virtual ICollection<ProductAttributeMapping> ProductAttributeMappings { get; set; } = new List<ProductAttributeMapping>();
}