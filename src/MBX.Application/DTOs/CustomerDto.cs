namespace MBX.Application.DTOs;

public record CreateCustomerDto(
    string FirstName,
    string LastName,
    string Email,
    string Password,
    string? PhoneNumber,
    string? Address,
    string? City,
    string? Region,
    string? PostalCode,
    string? Country
);

public record UpdateCustomerDto(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string? PhoneNumber,
    string? Address,
    string? City,
    string? Region,
    string? PostalCode,
    string? Country
);

public record CustomerDto(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string? PhoneNumber,
    string? Address,
    string? City,
    string? Region,
    string? PostalCode,
    string? Country,
    DateTime RegistrationDate
);