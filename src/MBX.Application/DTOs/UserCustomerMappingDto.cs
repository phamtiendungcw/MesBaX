namespace MBX.Application.DTOs;

public record CreateUserCustomerMappingDto(
    Guid UserId,
    Guid CustomerId
);

public record UpdateUserCustomerMappingDto(
    Guid Id,
    Guid UserId,
    Guid CustomerId
);

public record UserCustomerMappingDto(
    Guid Id,
    Guid UserId,
    string Username,
    Guid CustomerId,
    string CustomerName
);