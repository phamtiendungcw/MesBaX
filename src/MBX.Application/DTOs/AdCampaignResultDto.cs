namespace MBX.Application.DTOs;

public record CreateAdCampaignResultDto(
    Guid CampaignId,
    int Impressions,
    int Clicks,
    int Conversions,
    decimal Cost,
    decimal? Roas
);

public record UpdateAdCampaignResultDto(
    Guid Id,
    Guid CampaignId,
    int Impressions,
    int Clicks,
    int Conversions,
    decimal Cost,
    decimal? Roas
);

public record AdCampaignResultDto(
    Guid Id,
    Guid CampaignId,
    string CampaignName,
    int Impressions,
    int Clicks,
    int Conversions,
    decimal Cost,
    decimal? Roas
);