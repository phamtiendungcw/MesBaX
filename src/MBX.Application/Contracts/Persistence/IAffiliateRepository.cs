using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IAffiliateRepository : IGenericRepository<Affiliate>
{
    Task<Affiliate> GetAffiliateByEmailAsync(string email);

    Task<Affiliate> GetAffiliateByUrlAsync(string url);
}