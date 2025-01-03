using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class CustomerGroup : BaseEntity
{
    public string GroupName { get; set; } = string.Empty;
    public string GroupDescription { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<CustomerCustomerGroupMapping> CustomerCustomerGroupMappings { get; set; } = new List<CustomerCustomerGroupMapping>();
}