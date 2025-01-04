namespace MBX.Application.DTOs;

public record CreateAdCampaignDto(
    string Platform,
    string CampaignName,
    DateTime StartDate,
    DateTime EndDate,
    decimal Budget,
    string? TargetAudience
);

public record UpdateAdCampaignDto(
    Guid Id,
    string Platform,
    string CampaignName,
    DateTime StartDate,
    DateTime EndDate,
    decimal Budget,
    string? TargetAudience
);

public record AdCampaignDto(
    Guid Id,
    string Platform,
    string CampaignName,
    DateTime StartDate,
    DateTime EndDate,
    decimal Budget,
    string? TargetAudience
);