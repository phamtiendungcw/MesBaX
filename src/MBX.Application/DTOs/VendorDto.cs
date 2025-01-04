namespace MBX.Application.DTOs;

public record CreateVendorDto(
    string VendorName,
    string Email,
    string Description,
    string PhoneNumber,
    string Address,
    decimal Rating
);

public record UpdateVendorDto(
    Guid Id,
    string VendorName,
    string Email,
    string Description,
    string PhoneNumber,
    string Address,
    decimal Rating
);

public record VendorDto(
    Guid Id,
    string VendorName,
    string Email,
    string Description,
    string PhoneNumber,
    string Address,
    decimal Rating,
    DateTime CreatedDate,
    DateTime UpdatedDate
);