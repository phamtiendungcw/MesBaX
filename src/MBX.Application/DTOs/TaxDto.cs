namespace MBX.Application.DTOs;

public record CreateTaxDto(
    string TaxName,
    decimal TaxRate,
    string TaxType,
    string Country,
    string Region
);

public record UpdateTaxDto(
    Guid Id,
    string TaxName,
    decimal TaxRate,
    string TaxType,
    string Country,
    string Region
);

public record TaxDto(
    Guid Id,
    string TaxName,
    decimal TaxRate,
    string TaxType,
    string Country,
    string Region
);