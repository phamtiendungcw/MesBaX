using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IGiftCardRepository : IGenericRepository<GiftCard>
{
    Task<GiftCard> GetGiftCardByCodeAsync(string code);

    Task<IReadOnlyList<GiftCard>> GetGiftCardByCreateDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 10);

    Task<IReadOnlyList<GiftCard>> GetGiftCardByExpiredDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 10);
}