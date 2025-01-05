namespace MBX.Application.DTOs;

public record CreateSocialMediaPostDto(
    string Platform,
    string PostContent,
    DateTime PostDate,
    string PostUrl,
    Guid? ProductId,
    int Reach,
    int Engagement
);

public record UpdateSocialMediaPostDto(
    Guid Id,
    string Platform,
    string PostContent,
    DateTime PostDate,
    string PostUrl,
    Guid? ProductId,
    int Reach,
    int Engagement
);

public record SocialMediaPostDto(
    Guid Id,
    string Platform,
    string PostContent,
    DateTime PostDate,
    string PostUrl,
    Guid? ProductId,
    string? ProductName,
    int Reach,
    int Engagement
);