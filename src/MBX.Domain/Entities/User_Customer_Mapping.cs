using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class User_Customer_Mapping
{
    [Key] public Guid UserCustomerID { get; set; } = Guid.NewGuid();

    public Guid UserID { get; set; }
    public Guid CustomerID { get; set; }

    // Navigation properties
    [ForeignKey("UserID")] public virtual User User { get; set; } = null!;

    [ForeignKey("CustomerID")] public virtual Customer Customer { get; set; } = null!;
}