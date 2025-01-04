namespace MBX.Application.DTOs;

public record CreateNewsletterSubscriptionDto(
    string Email
);

public record UpdateNewsletterSubscriptionDto(
    Guid Id,
    string Email,
    bool IsActive
);

public record NewsletterSubscriptionDto(
    Guid Id,
    string Email,
    DateTime SubscriptionDate,
    bool IsActive
);