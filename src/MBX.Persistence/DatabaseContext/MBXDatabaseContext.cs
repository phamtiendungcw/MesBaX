using System.Linq.Expressions;

using MBX.Domain.Common;
using MBX.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MBX.Persistence.DatabaseContext;

public class MbxDatabaseContext : DbContext
{
    private readonly ILogger<MbxDatabaseContext> _logger;

    public MbxDatabaseContext(DbContextOptions<MbxDatabaseContext> options, ILogger<MbxDatabaseContext> logger) : base(options)
    {
        _logger = logger;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Apply configurations from the assembly of configurations
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MbxDatabaseContext).Assembly);

        // Apply query filters for soft-deleted entities
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
                modelBuilder.Entity(entityType.ClrType).HasQueryFilter(GetIsDeletedFilterExpression(entityType.ClrType));

        base.OnModelCreating(modelBuilder);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        try
        {
            UpdateAuditFields();
            HandleSoftDelete();
            return await base.SaveChangesAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error when saving changes");
            throw;
        }
    }

    public override int SaveChanges()
    {
        try
        {
            UpdateAuditFields();
            HandleSoftDelete();
            return base.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error when saving changes");
            throw;
        }
    }

    private void UpdateAuditFields()
    {
        var entries = ChangeTracker.Entries<BaseEntity>()
            .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

        foreach (var entry in entries)
        {
            entry.Entity.ModifiedAt = DateTime.UtcNow;
            if (entry.State == EntityState.Added) entry.Entity.CreatedAt = DateTime.UtcNow;
        }
    }

    private void HandleSoftDelete()
    {
        var entries = ChangeTracker.Entries<BaseEntity>()
            .Where(e => e.State == EntityState.Deleted);

        foreach (var entry in entries)
        {
            entry.State = EntityState.Modified;
            entry.Entity.IsDeleted = true;
        }
    }

    private LambdaExpression GetIsDeletedFilterExpression(Type type)
    {
        var parameter = Expression.Parameter(type, "x");
        var property = Expression.Property(parameter, nameof(BaseEntity.IsDeleted));
        var constant = Expression.Constant(false);
        var body = Expression.Equal(property, constant);
        return Expression.Lambda(body, parameter);
    }

    #region DbSet properties for each entity

    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Supplier> Suppliers { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<ProductAttribute> ProductAttributes { get; set; } = null!;
    public DbSet<ProductAttributeValue> ProductAttributeValues { get; set; } = null!;
    public DbSet<ProductAttributeMapping> ProductAttributeMappings { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;
    public DbSet<Wishlist> Wishlists { get; set; } = null!;
    public DbSet<Cart> Carts { get; set; } = null!;
    public DbSet<CartItem> CartItems { get; set; } = null!;
    public DbSet<InventoryTransaction> InventoryTransactions { get; set; } = null!;
    public DbSet<Payment> Payments { get; set; } = null!;
    public DbSet<ShippingMethod> ShippingMethods { get; set; } = null!;
    public DbSet<Promotion> Promotions { get; set; } = null!;
    public DbSet<SocialMediaPost> SocialMediaPosts { get; set; } = null!;
    public DbSet<AdCampaign> AdCampaigns { get; set; } = null!;
    public DbSet<AdCampaignResult> AdCampaignResults { get; set; } = null!;
    public DbSet<CustomerAddress> CustomerAddresses { get; set; } = null!;
    public DbSet<CustomerGroup> CustomerGroups { get; set; } = null!;
    public DbSet<CustomerCustomerGroupMapping> CustomerCustomerGroupMappings { get; set; } = null!;
    public DbSet<Tax> Taxes { get; set; } = null!;
    public DbSet<ProductTax> ProductTaxes { get; set; } = null!;
    public DbSet<Discount> Discounts { get; set; } = null!;
    public DbSet<DiscountAppliedToProducts> DiscountAppliedToProducts { get; set; } = null!;
    public DbSet<DiscountAppliedToCategories> DiscountAppliedToCategories { get; set; } = null!;
    public DbSet<GiftCard> GiftCards { get; set; } = null!;
    public DbSet<GiftCardUsageHistory> GiftCardUsageHistories { get; set; } = null!;
    public DbSet<ReturnRequest> ReturnRequests { get; set; } = null!;
    public DbSet<BlogPost> BlogPosts { get; set; } = null!;
    public DbSet<BlogComment> BlogComments { get; set; } = null!;
    public DbSet<NewsletterSubscription> NewsletterSubscriptions { get; set; } = null!;
    public DbSet<Affiliate> Affiliates { get; set; } = null!;
    public DbSet<OrderAffiliate> OrderAffiliates { get; set; } = null!;
    public DbSet<Vendor> Vendors { get; set; } = null!;
    public DbSet<VendorProduct> VendorProducts { get; set; } = null!;
    public DbSet<UserCustomerMapping> UserCustomerMappings { get; set; } = null!;

    #endregion DbSet properties for each entity
}