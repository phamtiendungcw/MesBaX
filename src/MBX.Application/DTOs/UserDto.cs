namespace MBX.Application.DTOs;

public record CreateUserDto(
    Guid RoleId,
    string Username,
    string Password,
    string Email,
    string FirstName,
    string LastName,
    bool IsActive
);

public record UpdateUserDto(
    Guid Id,
    Guid RoleId,
    string Username,
    string Email,
    string FirstName,
    string LastName,
    bool IsActive
);

public record UserDto(
    Guid Id,
    Guid RoleId,
    string RoleName,
    string Username,
    string Email,
    string FirstName,
    string LastName,
    bool IsActive,
    DateTime CreatedDate
);