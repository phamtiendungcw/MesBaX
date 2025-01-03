using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities;

public class Customer
{
    [Key] public Guid CustomerID { get; set; } = Guid.NewGuid();

    [MaxLength(100)] public string FirstName { get; set; } = string.Empty;

    [MaxLength(100)] public string LastName { get; set; } = string.Empty;

    [Required] [MaxLength(255)] public string Email { get; set; } = string.Empty;

    [Required] public string Password { get; set; } = string.Empty; // Consider hashing the password

    [MaxLength(20)] public string PhoneNumber { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();
    public virtual ICollection<Customer_CustomerGroup_Mapping> CustomerCustomerGroupMappings { get; set; } = new List<Customer_CustomerGroup_Mapping>();
    public virtual ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
    public virtual ICollection<BlogComment> BlogComments { get; set; } = new List<BlogComment>();
    public virtual ICollection<User_Customer_Mapping> UserCustomerMappings { get; set; } = new List<User_Customer_Mapping>();
}