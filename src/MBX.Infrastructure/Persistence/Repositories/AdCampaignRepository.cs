using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class AdCampaignRepository : GenericRepository<AdCampaign>, IAdCampaignRepository
{
    public AdCampaignRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<AdCampaign>> GetCampaignsByPlatformAsync(string platform, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.AdCampaigns
            .Where(c => c.Platform == platform && !c.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<AdCampaign>> GetCampaignsByDateRangeAsync(DateTime startDate, DateTime endDate, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.AdCampaigns
            .Where(c => c.StartDate >= startDate && c.EndDate <= endDate && !c.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<AdCampaign> GetCampaignByNameAsync(string campaignName)
    {
        return await _context.AdCampaigns.FirstOrDefaultAsync(c => c.CampaignName == campaignName && !c.IsDeleted) ?? throw new NotFoundException(nameof(AdCampaign), campaignName);
    }
}