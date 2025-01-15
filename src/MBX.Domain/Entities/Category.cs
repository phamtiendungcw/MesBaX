using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class Category : BaseEntity
{
    [Required][MaxLength(255)] public string CategoryName { get; set; } = string.Empty;
    public string CategoryDescription { get; set; } = string.Empty;
    public Guid? ParentCategoryId { get; set; }

    // Navigation properties
    [ForeignKey("ParentCategoryId")] public virtual Category? ParentCategory { get; set; }
    public virtual ICollection<Category> SubCategories { get; set; } = new List<Category>();
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    public virtual ICollection<DiscountAppliedToCategories> DiscountAppliedToCategories { get; set; } = new List<DiscountAppliedToCategories>();
}