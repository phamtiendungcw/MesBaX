namespace MBX.Application.DTOs;

public record CreateProductAttributeMappingDto(
    Guid ProductId,
    Guid AttributeValueId
);

public record UpdateProductAttributeMappingDto(
    Guid Id,
    Guid ProductId,
    Guid AttributeValueId
);

public record ProductAttributeMappingDto(
    Guid Id,
    Guid ProductId,
    Guid AttributeValueId,
    string AttributeName,
    string AttributeValue
);