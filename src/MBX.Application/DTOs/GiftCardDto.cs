namespace MBX.Application.DTOs;

public record CreateGiftCardDto(
    string GiftCardCode,
    decimal InitialValue,
    DateTime ExpirationDate,
    string RecipientName,
    string RecipientEmail,
    string SenderName,
    string SenderEmail,
    string Message
);

public record UpdateGiftCardDto(
    Guid Id,
    string GiftCardCode,
    decimal InitialValue,
    decimal RemainingValue,
    DateTime ExpirationDate,
    bool IsActive,
    string RecipientName,
    string RecipientEmail,
    string SenderName,
    string SenderEmail,
    string Message
);

public record GiftCardDto(
    Guid Id,
    string GiftCardCode,
    decimal InitialValue,
    decimal RemainingValue,
    DateTime ExpirationDate,
    bool IsActive,
    string RecipientName,
    string RecipientEmail,
    string SenderName,
    string SenderEmail,
    string Message
);