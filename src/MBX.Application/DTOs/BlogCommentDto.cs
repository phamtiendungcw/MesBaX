namespace MBX.Application.DTOs;

public record CreateBlogCommentDto(
    Guid PostId,
    Guid? CustomerId,
    string Name,
    string Email,
    string CommentText,
    bool IsApproved
);

public record UpdateBlogCommentDto(
    Guid Id,
    Guid PostId,
    Guid? CustomerId,
    string Name,
    string Email,
    string CommentText,
    bool IsApproved
);

public record BlogCommentDto(
    Guid Id,
    Guid PostId,
    string PostTitle,
    Guid? CustomerId,
    string? CustomerName,
    string Name,
    string Email,
    string CommentText,
    DateTime CommentDate,
    bool IsApproved
);