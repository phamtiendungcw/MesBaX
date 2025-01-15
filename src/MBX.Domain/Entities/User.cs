using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class User : BaseEntity
{
    public Guid RoleId { get; set; }
    [Required][MaxLength(50)] public string Username { get; set; } = string.Empty;
    [Required] public string Password { get; set; } = string.Empty; // Consider hashing the password
    [MaxLength(255)] public string Email { get; set; } = string.Empty;
    [MaxLength(100)] public string FirstName { get; set; } = string.Empty;
    [MaxLength(100)] public string LastName { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("RoleId")] public virtual Role Role { get; set; } = null!;
    public virtual ICollection<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
    public virtual ICollection<UserCustomerMapping> UserCustomerMappings { get; set; } = new List<UserCustomerMapping>();
}