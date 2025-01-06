using MBX.Application.Contracts.Persistence;
using MBX.Application.Contracts.Persistence.Common;
using MBX.Infrastructure.Persistence.Repositories;
using MBX.Infrastructure.Persistence.Repositories.Common;
using Microsoft.Extensions.DependencyInjection;

namespace MBX.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IProductAttributeRepository, ProductAttributeRepository>();
        services.AddScoped<IProductAttributeValueRepository, ProductAttributeValueRepository>();
        services.AddScoped<IProductAttributeMappingRepository, ProductAttributeMappingRepository>();
        services.AddScoped<IReviewRepository, ReviewRepository>();
        services.AddScoped<IWishlistRepository, WishlistRepository>();
        services.AddScoped<ICartRepository, CartRepository>();
        services.AddScoped<ICartItemRepository, CartItemRepository>();
        services.AddScoped<IInventoryTransactionRepository, InventoryTransactionRepository>();
        services.AddScoped<IPaymentRepository, PaymentRepository>();
        services.AddScoped<IShippingMethodRepository, ShippingMethodRepository>();
        services.AddScoped<IPromotionRepository, PromotionRepository>();
        services.AddScoped<ISocialMediaPostRepository, SocialMediaPostRepository>();
        services.AddScoped<IAdCampaignRepository, AdCampaignRepository>();
        services.AddScoped<IAdCampaignResultRepository, AdCampaignResultRepository>();
        services.AddScoped<ICustomerAddressRepository, CustomerAddressRepository>();
        services.AddScoped<ICustomerGroupRepository, CustomerGroupRepository>();
        services.AddScoped<ICustomerCustomerGroupMappingRepository, CustomerCustomerGroupMappingRepository>();
        services.AddScoped<ITaxRepository, TaxRepository>();
        services.AddScoped<IProductTaxRepository, ProductTaxRepository>();
        services.AddScoped<IDiscountRepository, DiscountRepository>();
        services.AddScoped<IDiscountAppliedToProductsRepository, DiscountAppliedToProductsRepository>();
        services.AddScoped<IDiscountAppliedToCategoriesRepository, DiscountAppliedToCategoriesRepository>();
        services.AddScoped<IGiftCardRepository, GiftCardRepository>();
        services.AddScoped<IGiftCardUsageHistoryRepository, GiftCardUsageHistoryRepository>();
        services.AddScoped<IReturnRequestRepository, ReturnRequestRepository>();
        services.AddScoped<IBlogPostRepository, BlogPostRepository>();
        services.AddScoped<IBlogCommentRepository, BlogCommentRepository>();
        services.AddScoped<INewsletterSubscriptionRepository, NewsletterSubscriptionRepository>();
        services.AddScoped<IAffiliateRepository, AffiliateRepository>();
        services.AddScoped<IOrderAffiliateRepository, OrderAffiliateRepository>();
        services.AddScoped<IVendorRepository, VendorRepository>();
        services.AddScoped<IVendorProductRepository, VendorProductRepository>();
        services.AddScoped<IUserCustomerMappingRepository, UserCustomerMappingRepository>();
        return services;
    }
}