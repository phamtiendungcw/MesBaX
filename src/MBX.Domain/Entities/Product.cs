using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Product
{
    [Key] public Guid ProductID { get; set; } = Guid.NewGuid();

    [Required][MaxLength(255)] public string ProductName { get; set; } = string.Empty;

    public string ProductDescription { get; set; } = string.Empty;
    public Guid CategoryID { get; set; }
    public Guid? SupplierID { get; set; }

    [Column(TypeName = "decimal(18, 2)")] public decimal UnitPrice { get; set; }

    [Column(TypeName = "decimal(18, 2)")] public decimal CostPrice { get; set; }

    public int UnitsInStock { get; set; }
    public int UnitsOnOrder { get; set; }
    public int ReorderLevel { get; set; }
    public bool Discontinued { get; set; }

    [MaxLength(50)] public string SKU { get; set; } = string.Empty;

    public string ProductImage { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("CategoryID")] public virtual Category Category { get; set; } = null!;

    [ForeignKey("SupplierID")] public virtual Supplier? Supplier { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    public virtual ICollection<Product_Attribute_Mapping> ProductAttributeMappings { get; set; } = new List<Product_Attribute_Mapping>();
    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    public virtual ICollection<ProductTax> ProductTaxes { get; set; } = new List<ProductTax>();
    public virtual ICollection<Discount_AppliedTo_Products> DiscountAppliedToProducts { get; set; } = new List<Discount_AppliedTo_Products>();
    public virtual ICollection<SocialMediaPost> SocialMediaPosts { get; set; } = new List<SocialMediaPost>();
    public virtual ICollection<VendorProduct> VendorProducts { get; set; } = new List<VendorProduct>();
}