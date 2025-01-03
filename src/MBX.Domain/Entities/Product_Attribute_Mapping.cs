using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Product_Attribute_Mapping
{
    [Key] public Guid ProductAttributeMappingID { get; set; } = Guid.NewGuid();

    public Guid ProductID { get; set; }
    public Guid AttributeValueID { get; set; }

    // Navigation properties
    [ForeignKey("ProductID")] public virtual Product Product { get; set; } = null!;

    [ForeignKey("AttributeValueID")] public virtual ProductAttributeValue ProductAttributeValue { get; set; } = null!;
}