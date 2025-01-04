namespace MBX.Application.DTOs;

public record CreateDiscountAppliedToProductsDto(
    Guid DiscountId,
    Guid ProductId
);

public record UpdateDiscountAppliedToProductsDto(
    Guid Id,
    Guid DiscountId,
    Guid ProductId
);

public record DiscountAppliedToProductsDto(
    Guid Id,
    Guid DiscountId,
    string DiscountName,
    Guid ProductId,
    string ProductName
);