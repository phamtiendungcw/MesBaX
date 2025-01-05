namespace MBX.Application.DTOs;

public record CreateVendorProductDto(
    Guid VendorId,
    Guid ProductId
);

public record UpdateVendorProductDto(
    Guid Id,
    Guid VendorId,
    Guid ProductId
);

public record VendorProductDto(
    Guid Id,
    Guid VendorId,
    string VendorName,
    Guid ProductId,
    string ProductName
);