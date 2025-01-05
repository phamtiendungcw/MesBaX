namespace MBX.Application.DTOs;

public record CreateRoleDto(
    string RoleName,
    string RoleDescription
);

public record UpdateRoleDto(
    Guid Id,
    string RoleName,
    string RoleDescription
);

public record RoleDto(
    Guid Id,
    string RoleName,
    string RoleDescription
);