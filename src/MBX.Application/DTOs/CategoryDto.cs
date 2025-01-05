namespace MBX.Application.DTOs;

public record CreateCategoryDto(
    string CategoryName,
    string CategoryDescription,
    Guid? ParentCategoryId
);

public record UpdateCategoryDto(
    Guid Id,
    string CategoryName,
    string CategoryDescription,
    Guid? ParentCategoryId
);

public record CategoryDto(
    Guid Id,
    string CategoryName,
    string CategoryDescription,
    Guid? ParentCategoryId,
    string? ParentCategoryName,
    List<CategoryDto>? SubCategories
);