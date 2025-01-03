using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Customer_CustomerGroup_Mapping
{
    [Key] public Guid CustomerGroupMappingID { get; set; } = Guid.NewGuid();

    public Guid CustomerID { get; set; }
    public Guid GroupID { get; set; }

    // Navigation properties
    [ForeignKey("CustomerID")] public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("GroupID")] public virtual CustomerGroup CustomerGroup { get; set; } = null!;
}