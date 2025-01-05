namespace MBX.Application.DTOs;

public record CreateOrderAffiliateDto(
    Guid OrderId,
    Guid AffiliateId
);

public record UpdateOrderAffiliateDto(
    Guid Id,
    Guid OrderId,
    Guid AffiliateId
);

public record OrderAffiliateDto(
    Guid Id,
    Guid OrderId,
    Guid AffiliateId,
    string AffiliateName
);