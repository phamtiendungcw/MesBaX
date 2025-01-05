using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IReviewRepository : IGenericRepository<Review>
{
    Task<IReadOnlyList<Review>> GetReviewsByProductIdAsync(Guid productId, int pageNumber = 1, int pageSize = 10);
    Task<IReadOnlyList<Review>> GetReviewsByCustomerIdAsync(Guid customerId, int pageNumber = 1, int pageSize = 10);
    Task<double> GetAverageRatingForProductAsync(Guid productId);
}