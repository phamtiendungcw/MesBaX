namespace MBX.Application.DTOs;

public record CreateAffiliateDto(
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber,
    string Address,
    decimal CommissionRate,
    string AffiliateUrl
);

public record UpdateAffiliateDto(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber,
    string Address,
    decimal CommissionRate,
    string AffiliateUrl
);

public record AffiliateDto(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber,
    string Address,
    decimal CommissionRate,
    string AffiliateUrl
);