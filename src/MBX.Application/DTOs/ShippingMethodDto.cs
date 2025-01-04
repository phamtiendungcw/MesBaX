namespace MBX.Application.DTOs;

public record CreateShippingMethodDto(
    string Name,
    string Description,
    decimal Cost
);

public record UpdateShippingMethodDto(
    Guid Id,
    string Name,
    string Description,
    decimal Cost
);

public record ShippingMethodDto(
    Guid Id,
    string Name,
    string Description,
    decimal Cost
);