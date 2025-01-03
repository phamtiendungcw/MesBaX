using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities;

public class ProductAttribute
{
    [Key] public Guid AttributeID { get; set; } = Guid.NewGuid();

    [Required][MaxLength(255)] public string AttributeName { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = new List<ProductAttributeValue>();
}