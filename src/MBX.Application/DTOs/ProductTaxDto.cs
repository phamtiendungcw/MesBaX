namespace MBX.Application.DTOs;

public record CreateProductTaxDto(
    Guid ProductId,
    Guid TaxId
);

public record UpdateProductTaxDto(
    Guid Id,
    Guid ProductId,
    Guid TaxId
);

public record ProductTaxDto(
    Guid Id,
    Guid ProductId,
    string ProductName,
    Guid TaxId,
    string TaxName
);