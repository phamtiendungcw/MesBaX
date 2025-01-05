namespace MBX.Application.DTOs;

public record CreateProductDto(
    string ProductName,
    string ProductDescription,
    Guid CategoryId,
    Guid? SupplierId,
    decimal UnitPrice,
    decimal CostPrice,
    int UnitsInStock,
    int UnitsOnOrder,
    int ReorderLevel,
    bool Discontinued,
    string Sku,
    string? ProductImage
);

public record UpdateProductDto(
    Guid Id,
    string ProductName,
    string ProductDescription,
    Guid CategoryId,
    Guid? SupplierId,
    decimal UnitPrice,
    decimal CostPrice,
    int UnitsInStock,
    int UnitsOnOrder,
    int ReorderLevel,
    bool Discontinued,
    string Sku,
    string? ProductImage
);

public record ProductDto(
    Guid Id,
    string ProductName,
    string ProductDescription,
    Guid CategoryId,
    string CategoryName,
    Guid? SupplierId,
    string? SupplierName,
    decimal UnitPrice,
    decimal CostPrice,
    int UnitsInStock,
    int UnitsOnOrder,
    int ReorderLevel,
    bool Discontinued,
    string Sku,
    string? ProductImage,
    DateTime CreatedDate,
    DateTime UpdatedDate
);