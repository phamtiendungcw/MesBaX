namespace MBX.Application.DTOs;

public record CreateGiftCardUsageHistoryDto(
    Guid GiftCardId,
    Guid OrderId,
    decimal UsedAmount
);

public record UpdateGiftCardUsageHistoryDto(
    Guid Id,
    Guid GiftCardId,
    Guid OrderId,
    decimal UsedAmount
);

public record GiftCardUsageHistoryDto(
    Guid Id,
    Guid GiftCardId,
    string GiftCardCode,
    Guid OrderId,
    decimal UsedAmount,
    DateTime UsedDate
);