using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class GiftCardRepository : GenericRepository<GiftCard>, IGiftCardRepository
{
    public GiftCardRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<GiftCard> GetGiftCardByCodeAsync(string code)
    {
        return await _context.GiftCards.FirstOrDefaultAsync(gc => gc.GiftCardCode == code && !gc.IsDeleted) ?? throw new NotFoundException(nameof(Discount), code);
    }

    public async Task<IReadOnlyList<GiftCard>> GetGiftCardByCreateDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.GiftCards
            .Where(gc => gc.CreatedAt == dateTime && !gc.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<GiftCard>> GetGiftCardByExpiredDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.GiftCards
            .Where(gc => gc.ExpirationDate == dateTime && !gc.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}