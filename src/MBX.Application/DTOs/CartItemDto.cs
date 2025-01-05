namespace MBX.Application.DTOs;

public record CreateCartItemDto(
    Guid CartId,
    Guid ProductId,
    int Quantity
);

public record UpdateCartItemDto(
    Guid Id,
    Guid CartId,
    Guid ProductId,
    int Quantity
);

public record CartItemDto(
    Guid Id,
    Guid ProductId,
    string ProductName,
    int Quantity,
    DateTime AddedDate
);