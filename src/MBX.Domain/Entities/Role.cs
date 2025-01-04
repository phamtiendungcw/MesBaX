using MBX.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities;

public class Role : BaseEntity
{
    [Required][MaxLength(50)] public string RoleName { get; set; } = string.Empty;
    public string RoleDescription { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}