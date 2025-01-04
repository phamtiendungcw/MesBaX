namespace MBX.Application.DTOs;

public record CreateWishlistDto(
    Guid CustomerId,
    Guid ProductId
);

public record UpdateWishlistDto(
    Guid Id,
    Guid CustomerId,
    Guid ProductId
);

public record WishlistDto(
    Guid Id,
    Guid CustomerId,
    string CustomerName,
    Guid ProductId,
    string ProductName,
    DateTime CreateDate
);