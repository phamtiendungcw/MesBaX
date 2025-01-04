namespace MBX.Application.DTOs;

public record CreateReviewDto(
    Guid ProductId,
    Guid CustomerId,
    int Rating,
    string Comment
);

public record UpdateReviewDto(
    Guid Id,
    int Rating,
    string Comment
);

public record ReviewDto(
    Guid Id,
    Guid ProductId,
    string ProductName,
    Guid CustomerId,
    string CustomerName,
    int Rating,
    string Comment,
    DateTime ReviewDate
);