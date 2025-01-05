using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class UserCustomerMapping : BaseEntity
{
    public Guid UserId { get; set; }
    public Guid CustomerId { get; set; }

    // Navigation properties
    [ForeignKey("UserId")] public virtual User User { get; set; } = null!;
    [ForeignKey("CustomerId")] public virtual Customer Customer { get; set; } = null!;
}