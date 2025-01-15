using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class SocialMediaPostRepository : GenericRepository<SocialMediaPost>, ISocialMediaPostRepository
{
    public SocialMediaPostRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<SocialMediaPost>> GetPostsByPlatformAsync(string platform, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.SocialMediaPosts
            .Where(p => p.Platform == platform && !p.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<SocialMediaPost>> GetPostsByProductIdAsync(Guid? productId, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.SocialMediaPosts
            .Where(p => p.ProductId == productId && !p.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<SocialMediaPost>> GetPostsByDateRangeAsync(DateTime startDate, DateTime endDate, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.SocialMediaPosts
            .Where(p => p.PostDate >= startDate && p.PostDate <= endDate && !p.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}