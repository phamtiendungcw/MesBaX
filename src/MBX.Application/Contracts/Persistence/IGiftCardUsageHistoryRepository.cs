using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IGiftCardUsageHistoryRepository : IGenericRepository<GiftCardUsageHistory>
{
    Task<IReadOnlyList<GiftCardUsageHistory>> GetUsageHistoryByGiftCardIdAsync(Guid giftCardId);
}