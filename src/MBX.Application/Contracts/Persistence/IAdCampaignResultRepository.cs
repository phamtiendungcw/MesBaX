using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IAdCampaignResultRepository : IGenericRepository<AdCampaignResult>
{
    Task<IReadOnlyList<AdCampaignResult>> GetCampaignResultsByCampaignIdAsync(Guid campaignId, int pageNumber = 1, int pageSize = 10);
}