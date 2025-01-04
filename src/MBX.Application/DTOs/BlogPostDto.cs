namespace MBX.Application.DTOs;

public record CreateBlogPostDto(
    string Title,
    string Content,
    Guid AuthorId,
    DateTime PublishDate,
    string Tags,
    string MetaKeywords,
    string MetaDescription
);

public record UpdateBlogPostDto(
    Guid Id,
    string Title,
    string Content,
    Guid AuthorId,
    DateTime PublishDate,
    string Tags,
    string MetaKeywords,
    string MetaDescription
);

public record BlogPostDto(
    Guid Id,
    string Title,
    string Content,
    Guid AuthorId,
    string AuthorName,
    DateTime PublishDate,
    string Tags,
    string MetaKeywords,
    string MetaDescription
);