using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class PromotionRepository : GenericRepository<Promotion>, IPromotionRepository
{
    public PromotionRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<Promotion> GetPromotionByCodeAsync(string code)
    {
        return await _context.Promotions.FirstOrDefaultAsync(p => p.Code == code && !p.IsDeleted) ?? throw new NotFoundException(nameof(Promotion), code);
    }

    public async Task<IReadOnlyList<Promotion>> GetActivePromotionsAsync(DateTime currentDate)
    {
        return await _context.Promotions.Where(p => p.IsActive && p.StartDate <= currentDate && p.EndDate >= currentDate && !p.IsDeleted).ToListAsync();
    }
}