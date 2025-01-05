namespace MBX.Application.DTOs;

public record CreateSupplierDto(
    string SupplierName,
    string ContactName,
    string ContactEmail,
    string ContactPhone,
    string Address
);

public record UpdateSupplierDto(
    Guid Id,
    string SupplierName,
    string ContactName,
    string ContactEmail,
    string ContactPhone,
    string Address
);

public record SupplierDto(
    Guid Id,
    string SupplierName,
    string ContactName,
    string ContactEmail,
    string ContactPhone,
    string Address
);