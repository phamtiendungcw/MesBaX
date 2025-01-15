using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class CustomerCustomerGroupMapping : BaseEntity
{
    public Guid CustomerId { get; set; }
    public Guid GroupId { get; set; }

    // Navigation properties
    [ForeignKey("CustomerId")] public virtual Customer Customer { get; set; } = null!;
    [ForeignKey("GroupId")] public virtual CustomerGroup CustomerGroup { get; set; } = null!;
}