using System.ComponentModel.DataAnnotations;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class ProductAttribute : BaseEntity
{
    [Required][MaxLength(255)] public string AttributeName { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = new List<ProductAttributeValue>();
}