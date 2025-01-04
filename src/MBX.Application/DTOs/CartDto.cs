namespace MBX.Application.DTOs;

public record CreateCartDto(
    Guid? CustomerId,
    string SessionId
);

public record UpdateCartDto(
    Guid Id,
    Guid? CustomerId,
    string SessionId
);

public record CartDto(
    Guid Id,
    Guid? CustomerId,
    string? CustomerName,
    string SessionId,
    DateTime CreatedDate,
    List<CartItemDto> CartItems
);