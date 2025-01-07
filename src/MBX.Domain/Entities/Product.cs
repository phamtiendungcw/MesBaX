using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class Product : BaseEntity
{
    [Required][MaxLength(255)] public string ProductName { get; set; } = string.Empty;
    public string ProductDescription { get; set; } = string.Empty;
    public Guid CategoryId { get; set; }
    public Guid? SupplierId { get; set; }
    [Column(TypeName = "decimal(18, 2)")] public decimal UnitPrice { get; set; }
    [Column(TypeName = "decimal(18, 2)")] public decimal CostPrice { get; set; }
    public int UnitsInStock { get; set; }
    public int UnitsOnOrder { get; set; }
    public int ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
    [MaxLength(50)] public string Sku { get; set; } = string.Empty;
    public string ProductImage { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("CategoryId")] public virtual Category Category { get; set; } = null!;

    [ForeignKey("SupplierId")] public virtual Supplier? Supplier { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    public virtual ICollection<ReturnRequest> ReturnRequests { get; set; } = new List<ReturnRequest>();
    public virtual ICollection<ProductAttributeMapping> ProductAttributeMappings { get; set; } = new List<ProductAttributeMapping>();
    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    public virtual ICollection<ProductTax> ProductTaxes { get; set; } = new List<ProductTax>();
    public virtual ICollection<DiscountAppliedToProducts> DiscountAppliedToProducts { get; set; } = new List<DiscountAppliedToProducts>();
    public virtual ICollection<SocialMediaPost> SocialMediaPosts { get; set; } = new List<SocialMediaPost>();
    public virtual ICollection<VendorProduct> VendorProducts { get; set; } = new List<VendorProduct>();
    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();
    public virtual ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
}