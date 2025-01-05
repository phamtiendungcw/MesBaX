namespace MBX.Application.DTOs;

public record CreateDiscountAppliedToCategoriesDto(
    Guid DiscountId,
    Guid CategoryId
);

public record UpdateDiscountAppliedToCategoriesDto(
    Guid Id,
    Guid DiscountId,
    Guid CategoryId
);

public record DiscountAppliedToCategoriesDto(
    Guid Id,
    Guid DiscountId,
    string DiscountName,
    Guid CategoryId,
    string CategoryName
);