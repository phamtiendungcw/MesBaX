using AutoMapper;
using MBX.Application.DTOs;
using MBX.Domain.Entities;

namespace MBX.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Product
        CreateMap<CreateProductDto, Product>();
        CreateMap<UpdateProductDto, Product>();
        CreateMap<Product, ProductDto>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
            .ForMember(dest => dest.SupplierName, opt => opt.MapFrom(src => src.Supplier != null ? src.Supplier.SupplierName : null));

        // Category
        CreateMap<CreateCategoryDto, Category>();
        CreateMap<UpdateCategoryDto, Category>();
        CreateMap<Category, CategoryDto>()
            .ForMember(dest => dest.ParentCategoryName, opt => opt.MapFrom(src => src.ParentCategory != null ? src.ParentCategory.CategoryName : null))
            .ForMember(dest => dest.SubCategories, opt => opt.MapFrom(src => src.SubCategories));

        // Supplier
        CreateMap<CreateSupplierDto, Supplier>();
        CreateMap<UpdateSupplierDto, Supplier>();
        CreateMap<Supplier, SupplierDto>();

        // Order
        CreateMap<CreateOrderDto, Order>();
        CreateMap<CreateOrderItemDto, OrderDetail>();
        CreateMap<UpdateOrderDto, Order>();
        CreateMap<Order, OrderDto>()
            .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FirstName + " " + src.Customer.LastName))
            .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderDetails));
        CreateMap<OrderDetail, OrderItemDto>()
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName));

        // Customer
        CreateMap<CreateCustomerDto, Customer>();
        CreateMap<UpdateCustomerDto, Customer>();
        CreateMap<Customer, CustomerDto>();

        // User
        CreateMap<CreateUserDto, User>();
        CreateMap<UpdateUserDto, User>();
        CreateMap<User, UserDto>()
            .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Role.RoleName));

        // Role
        CreateMap<CreateRoleDto, Role>();
        CreateMap<UpdateRoleDto, Role>();
        CreateMap<Role, RoleDto>();

        // ProductAttribute
        CreateMap<CreateProductAttributeDto, ProductAttribute>();
        CreateMap<UpdateProductAttributeDto, ProductAttribute>();
        CreateMap<ProductAttribute, ProductAttributeDto>();

        // ProductAttributeValue
        CreateMap<CreateProductAttributeValueDto, ProductAttributeValue>();
        CreateMap<UpdateProductAttributeValueDto, ProductAttributeValue>();
        CreateMap<ProductAttributeValue, ProductAttributeValueDto>()
            .ForMember(dest => dest.AttributeName, opt => opt.MapFrom(src => src.ProductAttribute.AttributeName));

        // ProductAttributeMapping
        CreateMap<CreateProductAttributeMappingDto, ProductAttributeMapping>();
        CreateMap<UpdateProductAttributeMappingDto, ProductAttributeMapping>();
        CreateMap<ProductAttributeMapping, ProductAttributeMappingDto>()
            .ForMember(dest => dest.AttributeName, opt => opt.MapFrom(src => src.ProductAttributeValue.ProductAttribute.AttributeName))
            .ForMember(dest => dest.AttributeValue, opt => opt.MapFrom(src => src.ProductAttributeValue.Value));

        // Review
        CreateMap<CreateReviewDto, Review>();
        CreateMap<UpdateReviewDto, Review>();
        CreateMap<Review, ReviewDto>()
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName))
            .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FirstName + " " + src.Customer.LastName));

        // Wishlist
        CreateMap<CreateWishlistDto, Wishlist>();
        CreateMap<UpdateWishlistDto, Wishlist>();
        CreateMap<Wishlist, WishlistDto>()
            .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FirstName + " " + src.Customer.LastName))
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName));

        // Cart
        CreateMap<CreateCartDto, Cart>();
        CreateMap<UpdateCartDto, Cart>();
        CreateMap<Cart, CartDto>()
            .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer != null ? src.Customer.FirstName + " " + src.Customer.LastName : null));

        // CartItem
        CreateMap<CreateCartItemDto, CartItem>();
        CreateMap<UpdateCartItemDto, CartItem>();
        CreateMap<CartItem, CartItemDto>()
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName));

        // InventoryTransaction
        CreateMap<CreateInventoryTransactionDto, InventoryTransaction>();
        CreateMap<UpdateInventoryTransactionDto, InventoryTransaction>();
        CreateMap<InventoryTransaction, InventoryTransactionDto>()
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName));

        // Payment
        CreateMap<CreatePaymentDto, Payment>();
        CreateMap<UpdatePaymentDto, Payment>();
        CreateMap<Payment, PaymentDto>();

        // ShippingMethod
        CreateMap<CreateShippingMethodDto, ShippingMethod>();
        CreateMap<UpdateShippingMethodDto, ShippingMethod>();
        CreateMap<ShippingMethod, ShippingMethodDto>();

        // Promotion
        CreateMap<CreatePromotionDto, Promotion>();
        CreateMap<UpdatePromotionDto, Promotion>();
        CreateMap<Promotion, PromotionDto>();

        // SocialMediaPost
        CreateMap<CreateSocialMediaPostDto, SocialMediaPost>();
        CreateMap<UpdateSocialMediaPostDto, SocialMediaPost>();
        CreateMap<SocialMediaPost, SocialMediaPostDto>()
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product != null ? src.Product.ProductName : null));

        // AdCampaign
        CreateMap<CreateAdCampaignDto, AdCampaign>();
        CreateMap<UpdateAdCampaignDto, AdCampaign>();
        CreateMap<AdCampaign, AdCampaignDto>();

        // AdCampaignResult
        CreateMap<CreateAdCampaignResultDto, AdCampaignResult>();
        CreateMap<UpdateAdCampaignResultDto, AdCampaignResult>();
        CreateMap<AdCampaignResult, AdCampaignResultDto>()
            .ForMember(dest => dest.CampaignName, opt => opt.MapFrom(src => src.AdCampaign.CampaignName));

        // CustomerAddress
        CreateMap<CreateCustomerAddressDto, CustomerAddress>();
        CreateMap<UpdateCustomerAddressDto, CustomerAddress>();
        CreateMap<CustomerAddress, CustomerAddressDto>();

        // CustomerGroup
        CreateMap<CreateCustomerGroupDto, CustomerGroup>();
        CreateMap<UpdateCustomerGroupDto, CustomerGroup>();
        CreateMap<CustomerGroup, CustomerGroupDto>();

        // CustomerCustomerGroupMapping
        CreateMap<CreateCustomerCustomerGroupMappingDto, CustomerCustomerGroupMapping>();
        CreateMap<UpdateCustomerCustomerGroupMappingDto, CustomerCustomerGroupMapping>();
        CreateMap<CustomerCustomerGroupMapping, CustomerCustomerGroupMappingDto>()
            .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FirstName + " " + src.Customer.LastName))
            .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.CustomerGroup.GroupName));

        // Tax
        CreateMap<CreateTaxDto, Tax>();
        CreateMap<UpdateTaxDto, Tax>();
        CreateMap<Tax, TaxDto>();

        // ProductTax
        CreateMap<CreateProductTaxDto, ProductTax>();
        CreateMap<UpdateProductTaxDto, ProductTax>();
        CreateMap<ProductTax, ProductTaxDto>()
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName))
            .ForMember(dest => dest.TaxName, opt => opt.MapFrom(src => src.Tax.TaxName));

        // Discount
        CreateMap<CreateDiscountDto, Discount>();
        CreateMap<UpdateDiscountDto, Discount>();
        CreateMap<Discount, DiscountDto>();

        // DiscountAppliedToProducts
        CreateMap<CreateDiscountAppliedToProductsDto, DiscountAppliedToProducts>();
        CreateMap<UpdateDiscountAppliedToProductsDto, DiscountAppliedToProducts>();
        CreateMap<DiscountAppliedToProducts, DiscountAppliedToProductsDto>()
            .ForMember(dest => dest.DiscountName, opt => opt.MapFrom(src => src.Discount.DiscountName))
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName));

        // DiscountAppliedToCategories
        CreateMap<CreateDiscountAppliedToCategoriesDto, DiscountAppliedToCategories>();
        CreateMap<UpdateDiscountAppliedToCategoriesDto, DiscountAppliedToCategories>();
        CreateMap<DiscountAppliedToCategories, DiscountAppliedToCategoriesDto>()
            .ForMember(dest => dest.DiscountName, opt => opt.MapFrom(src => src.Discount.DiscountName))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName));

        // GiftCard
        CreateMap<CreateGiftCardDto, GiftCard>();
        CreateMap<UpdateGiftCardDto, GiftCard>();
        CreateMap<GiftCard, GiftCardDto>();

        // GiftCardUsageHistory
        CreateMap<CreateGiftCardUsageHistoryDto, GiftCardUsageHistory>();
        CreateMap<UpdateGiftCardUsageHistoryDto, GiftCardUsageHistory>();
        CreateMap<GiftCardUsageHistory, GiftCardUsageHistoryDto>()
            .ForMember(dest => dest.GiftCardCode, opt => opt.MapFrom(src => src.GiftCard.GiftCardCode));

        // ReturnRequest
        CreateMap<CreateReturnRequestDto, ReturnRequest>();
        CreateMap<UpdateReturnRequestDto, ReturnRequest>();
        CreateMap<ReturnRequest, ReturnRequestDto>()
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName));

        // BlogPost
        CreateMap<CreateBlogPostDto, BlogPost>();
        CreateMap<UpdateBlogPostDto, BlogPost>();
        CreateMap<BlogPost, BlogPostDto>()
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.FirstName + " " + src.Author.LastName));

        // BlogComment
        CreateMap<CreateBlogCommentDto, BlogComment>();
        CreateMap<UpdateBlogCommentDto, BlogComment>();
        CreateMap<BlogComment, BlogCommentDto>()
            .ForMember(dest => dest.PostTitle, opt => opt.MapFrom(src => src.BlogPost.Title))
            .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer != null ? src.Customer.FirstName + " " + src.Customer.LastName : null));

        // NewsletterSubscription
        CreateMap<CreateNewsletterSubscriptionDto, NewsletterSubscription>();
        CreateMap<UpdateNewsletterSubscriptionDto, NewsletterSubscription>();
        CreateMap<NewsletterSubscription, NewsletterSubscriptionDto>();

        // Affiliate
        CreateMap<CreateAffiliateDto, Affiliate>();
        CreateMap<UpdateAffiliateDto, Affiliate>();
        CreateMap<Affiliate, AffiliateDto>();

        // OrderAffiliate
        CreateMap<CreateOrderAffiliateDto, OrderAffiliate>();
        CreateMap<UpdateOrderAffiliateDto, OrderAffiliate>();
        CreateMap<OrderAffiliate, OrderAffiliateDto>()
            .ForMember(dest => dest.AffiliateName, opt => opt.MapFrom(src => src.Affiliate.FirstName + " " + src.Affiliate.LastName));

        // Vendor
        CreateMap<CreateVendorDto, Vendor>();
        CreateMap<UpdateVendorDto, Vendor>();
        CreateMap<Vendor, VendorDto>();

        // VendorProduct
        CreateMap<CreateVendorProductDto, VendorProduct>();
        CreateMap<UpdateVendorProductDto, VendorProduct>();
        CreateMap<VendorProduct, VendorProductDto>()
            .ForMember(dest => dest.VendorName, opt => opt.MapFrom(src => src.Vendor.VendorName))
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName));

        // UserCustomerMapping
        CreateMap<CreateUserCustomerMappingDto, UserCustomerMapping>();
        CreateMap<UpdateUserCustomerMappingDto, UserCustomerMapping>();
        CreateMap<UserCustomerMapping, UserCustomerMappingDto>()
            .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.User.Username))
            .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FirstName + " " + src.Customer.LastName));
    }
}