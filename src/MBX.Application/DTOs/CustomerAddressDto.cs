namespace MBX.Application.DTOs;

public record CreateCustomerAddressDto(
    Guid CustomerId,
    string AddressType,
    string AddressLine1,
    string AddressLine2,
    string City,
    string Region,
    string PostalCode,
    string Country,
    bool IsDefault
);

public record UpdateCustomerAddressDto(
    Guid Id,
    Guid CustomerId,
    string AddressType,
    string AddressLine1,
    string AddressLine2,
    string City,
    string Region,
    string PostalCode,
    string Country,
    bool IsDefault
);

public record CustomerAddressDto(
    Guid Id,
    Guid CustomerId,
    string AddressType,
    string AddressLine1,
    string AddressLine2,
    string City,
    string Region,
    string PostalCode,
    string Country,
    bool IsDefault
);