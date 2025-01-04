namespace MBX.Application.DTOs;

public record CreatePromotionDto(
    string Code,
    string DiscountType,
    decimal DiscountValue,
    DateTime StartDate,
    DateTime EndDate,
    decimal MinimumOrderValue,
    int UsageLimit,
    bool IsActive
);

public record UpdatePromotionDto(
    Guid Id,
    string Code,
    string DiscountType,
    decimal DiscountValue,
    DateTime StartDate,
    DateTime EndDate,
    decimal MinimumOrderValue,
    int UsageLimit,
    bool IsActive
);

public record PromotionDto(
    Guid Id,
    string Code,
    string DiscountType,
    decimal DiscountValue,
    DateTime StartDate,
    DateTime EndDate,
    decimal MinimumOrderValue,
    int UsageLimit,
    int UsedCount,
    bool IsActive
);