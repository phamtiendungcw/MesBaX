namespace MBX.Application.DTOs;

public record CreatePaymentDto(
    Guid OrderId,
    string PaymentMethod,
    decimal Amount,
    string Status,
    string TransactionId
);

public record UpdatePaymentDto(
    Guid Id,
    string PaymentMethod,
    decimal Amount,
    string Status,
    string TransactionId
);

public record PaymentDto(
    Guid Id,
    Guid OrderId,
    string PaymentMethod,
    decimal Amount,
    DateTime PaymentDate,
    string Status,
    string TransactionId
);