using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class GiftCardUsageHistoryRepository : GenericRepository<GiftCardUsageHistory>, IGiftCardUsageHistoryRepository
{
    public GiftCardUsageHistoryRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<GiftCardUsageHistory>> GetUsageHistoryByGiftCardIdAsync(Guid giftCardId)
    {
        return await _context.GiftCardUsageHistories.Where(gh => gh.GiftCardId == giftCardId && !gh.IsDeleted).ToListAsync();
    }
}