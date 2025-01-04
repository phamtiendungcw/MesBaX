namespace MBX.Application.DTOs;

public record CreateCustomerGroupDto(
    string GroupName,
    string GroupDescription
);

public record UpdateCustomerGroupDto(
    Guid Id,
    string GroupName,
    string GroupDescription
);

public record CustomerGroupDto(
    Guid Id,
    string GroupName,
    string GroupDescription
);