namespace MBX.Application.DTOs;

public record CreateDiscountDto(
    string DiscountName,
    string DiscountType,
    decimal DiscountValue,
    DateTime StartDate,
    DateTime EndDate,
    bool RequiresCoupon,
    string CouponCode,
    int MinimumQuantity,
    decimal? MaximumDiscountAmount
);

public record UpdateDiscountDto(
    Guid Id,
    string DiscountName,
    string DiscountType,
    decimal DiscountValue,
    DateTime StartDate,
    DateTime EndDate,
    bool RequiresCoupon,
    string CouponCode,
    int MinimumQuantity,
    decimal? MaximumDiscountAmount
);

public record DiscountDto(
    Guid Id,
    string DiscountName,
    string DiscountType,
    decimal DiscountValue,
    DateTime StartDate,
    DateTime EndDate,
    bool RequiresCoupon,
    string CouponCode,
    int MinimumQuantity,
    decimal? MaximumDiscountAmount
);