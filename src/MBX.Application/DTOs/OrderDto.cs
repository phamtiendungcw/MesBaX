namespace MBX.Application.DTOs;

public record CreateOrderDto(
    Guid CustomerId,
    List<CreateOrderItemDto> OrderItems,
    string? Note,
    string? ShipAddress,
    string? ShipCity,
    string? ShipRegion,
    string? ShipPostalCode,
    string? ShipCountry,
    string? PaymentMethod
);

public record CreateOrderItemDto(
    Guid ProductId,
    int Quantity,
    decimal UnitPrice
);

public record UpdateOrderDto(
    Guid Id,
    string OrderStatus,
    DateTime? ShippedDate,
    string? ShipAddress,
    string? ShipCity,
    string? ShipRegion,
    string? ShipPostalCode,
    string? ShipCountry,
    string? PaymentStatus
);

public record OrderDto(
    Guid Id,
    Guid CustomerId,
    string CustomerName,
    DateTime OrderDate,
    DateTime? ShippedDate,
    string? ShipAddress,
    string? ShipCity,
    string? ShipRegion,
    string? ShipPostalCode,
    string? ShipCountry,
    decimal ShippingFee,
    string OrderStatus,
    string? PaymentMethod,
    string? PaymentStatus,
    List<OrderItemDto> OrderItems
);

public record OrderItemDto(
    Guid ProductId,
    string ProductName,
    int Quantity,
    decimal UnitPrice,
    decimal Discount
);