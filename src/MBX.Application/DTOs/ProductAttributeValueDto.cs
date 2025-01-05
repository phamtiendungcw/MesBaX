namespace MBX.Application.DTOs;

public record CreateProductAttributeValueDto(
    Guid AttributeId,
    string Value
);

public record UpdateProductAttributeValueDto(
    Guid Id,
    Guid AttributeId,
    string Value
);

public record ProductAttributeValueDto(
    Guid Id,
    Guid AttributeId,
    string AttributeName,
    string Value
);