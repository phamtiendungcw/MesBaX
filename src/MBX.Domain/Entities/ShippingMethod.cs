using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class ShippingMethod : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18, 2)")] public decimal Cost { get; set; }
}