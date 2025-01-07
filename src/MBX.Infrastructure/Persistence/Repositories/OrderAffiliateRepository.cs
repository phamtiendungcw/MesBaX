using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class OrderAffiliateRepository : GenericRepository<OrderAffiliate>, IOrderAffiliateRepository
{
    public OrderAffiliateRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<OrderAffiliate>> GetOrderAffiliatesByAffiliateIdAsync(Guid affiliateId, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.OrderAffiliates
            .Where(oa => oa.AffiliateId == affiliateId && !oa.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}