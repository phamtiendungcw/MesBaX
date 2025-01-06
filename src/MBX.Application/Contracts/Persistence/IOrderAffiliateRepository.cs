using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IOrderAffiliateRepository : IGenericRepository<OrderAffiliate>
{
    Task<IReadOnlyList<OrderAffiliate>> GetOrderAffiliatesByAffiliateIdAsync(Guid affiliateId, int pageNumber = 1, int pageSize = 20);
}