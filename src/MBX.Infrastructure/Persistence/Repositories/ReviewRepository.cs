using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class ReviewRepository : GenericRepository<Review>, IReviewRepository
{
    public ReviewRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<Review>> GetReviewsByProductIdAsync(Guid productId, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Reviews
            .Where(r => r.ProductId == productId && !r.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Review>> GetReviewsByCustomerIdAsync(Guid customerId, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Reviews
            .Where(r => r.CustomerId == customerId && !r.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<double> GetAverageRatingForProductAsync(Guid productId)
    {
        return await _context.Reviews.Where(r => r.ProductId == productId && !r.IsDeleted).AverageAsync(r => r.Rating);
    }
}