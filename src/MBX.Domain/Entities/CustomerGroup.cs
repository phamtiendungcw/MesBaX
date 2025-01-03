using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities;

public class CustomerGroup
{
    [Key] public Guid GroupID { get; set; } = Guid.NewGuid();

    public string GroupName { get; set; } = string.Empty;
    public string GroupDescription { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<Customer_CustomerGroup_Mapping> CustomerCustomerGroupMappings { get; set; } = new List<Customer_CustomerGroup_Mapping>();
}