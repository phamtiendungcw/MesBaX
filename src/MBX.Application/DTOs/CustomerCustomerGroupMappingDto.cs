namespace MBX.Application.DTOs;

public record CreateCustomerCustomerGroupMappingDto(
    Guid CustomerId,
    Guid GroupId
);

public record UpdateCustomerCustomerGroupMappingDto(
    Guid Id,
    Guid CustomerId,
    Guid GroupId
);

public record CustomerCustomerGroupMappingDto(
    Guid Id,
    Guid CustomerId,
    string CustomerName,
    Guid GroupId,
    string GroupName
);