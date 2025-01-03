using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities;

public class Category
{
    [Key] public Guid CategoryID { get; set; } = Guid.NewGuid();

    [Required][MaxLength(255)] public string CategoryName { get; set; } = string.Empty;

    public string CategoryDescription { get; set; } = string.Empty;
    public Guid? ParentCategoryID { get; set; }

    // Navigation properties
    [ForeignKey("ParentCategoryID")] public virtual Category? ParentCategory { get; set; }

    public virtual ICollection<Category> SubCategories { get; set; } = new List<Category>();
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    public virtual ICollection<Discount_AppliedTo_Categories> DiscountAppliedToCategories { get; set; } = new List<Discount_AppliedTo_Categories>();
}