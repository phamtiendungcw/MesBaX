using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class User
{
    [Key] public Guid UserID { get; set; } = Guid.NewGuid();

    public Guid RoleID { get; set; }

    [Required][MaxLength(50)] public string Username { get; set; } = string.Empty;

    [Required] public string Password { get; set; } = string.Empty; // Consider hashing the password

    [MaxLength(255)] public string Email { get; set; } = string.Empty;

    [MaxLength(100)] public string FirstName { get; set; } = string.Empty;

    [MaxLength(100)] public string LastName { get; set; } = string.Empty;

    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("RoleID")] public virtual Role Role { get; set; } = null!;

    public virtual ICollection<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
    public virtual ICollection<User_Customer_Mapping> UserCustomerMappings { get; set; } = new List<User_Customer_Mapping>();
}