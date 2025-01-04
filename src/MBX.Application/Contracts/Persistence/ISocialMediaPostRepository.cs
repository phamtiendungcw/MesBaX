using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface ISocialMediaPostRepository : IGenericRepository<SocialMediaPost>
{
    Task<IReadOnlyList<SocialMediaPost>> GetPostsByPlatformAsync(string platform, int pageNumber = 1, int pageSize = 10);

    Task<IReadOnlyList<SocialMediaPost>> GetPostsByProductIdAsync(Guid? productId, int pageNumber = 1, int pageSize = 10);

    Task<IReadOnlyList<SocialMediaPost>> GetPostsByDateRangeAsync(DateTime startDate, DateTime endDate, int pageNumber = 1, int pageSize = 10);
}