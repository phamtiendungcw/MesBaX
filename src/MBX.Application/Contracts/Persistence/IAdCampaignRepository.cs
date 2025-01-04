using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IAdCampaignRepository : IGenericRepository<AdCampaign>
{
    Task<IReadOnlyList<AdCampaign>> GetCampaignsByPlatformAsync(string platform, int pageNumber = 1, int pageSize = 10);

    Task<IReadOnlyList<AdCampaign>> GetCampaignsByDateRangeAsync(DateTime startDate, DateTime endDate, int pageNumber = 1, int pageSize = 10);

    Task<AdCampaign> GetCampaignByNameAsync(string campaignName);
}