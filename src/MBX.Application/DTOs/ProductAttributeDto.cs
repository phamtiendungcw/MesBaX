namespace MBX.Application.DTOs;

public record CreateProductAttributeDto(
    string AttributeName
);

public record UpdateProductAttributeDto(
    Guid Id,
    string AttributeName
);

public record ProductAttributeDto(
    Guid Id,
    string AttributeName
);