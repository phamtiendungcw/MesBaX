using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class ProductAttributeValue
{
    [Key] public Guid AttributeValueID { get; set; } = Guid.NewGuid();

    public Guid AttributeID { get; set; }

    [Required][MaxLength(255)] public string Value { get; set; } = string.Empty;

    // Navigation properties
    [ForeignKey("AttributeID")] public virtual ProductAttribute ProductAttribute { get; set; } = null!;

    public virtual ICollection<Product_Attribute_Mapping> ProductAttributeMappings { get; set; } = new List<Product_Attribute_Mapping>();
}