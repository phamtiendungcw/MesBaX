namespace MBX.Application.DTOs;

public record CreateInventoryTransactionDto(
    Guid ProductId,
    string TransactionType,
    int Quantity,
    string Reference
);

public record UpdateInventoryTransactionDto(
    Guid Id,
    Guid ProductId,
    string TransactionType,
    int Quantity,
    string Reference
);

public record InventoryTransactionDto(
    Guid Id,
    Guid ProductId,
    string ProductName,
    string TransactionType,
    int Quantity,
    DateTime TransactionDate,
    string Reference
);