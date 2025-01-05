namespace MBX.Application.DTOs;

public record CreateReturnRequestDto(
    Guid OrderId,
    Guid ProductId,
    int Quantity,
    string Reason,
    string RequestedAction
);

public record UpdateReturnRequestDto(
    Guid Id,
    Guid OrderId,
    Guid ProductId,
    int Quantity,
    string Reason,
    string RequestedAction,
    string Status
);

public record ReturnRequestDto(
    Guid Id,
    Guid OrderId,
    Guid ProductId,
    string ProductName,
    int Quantity,
    string Reason,
    string RequestedAction,
    DateTime RequestDate,
    string Status
);