using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class AdCampaignResultRepository : GenericRepository<AdCampaignResult>, IAdCampaignResultRepository
{
    public AdCampaignResultRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<AdCampaignResult>> GetCampaignResultsByCampaignIdAsync(Guid campaignId, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.AdCampaignResults
            .Where(r => r.CampaignId == campaignId && !r.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}