using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IPromotionRepository : IGenericRepository<Promotion>
{
    Task<Promotion> GetPromotionByCodeAsync(string code);

    Task<IReadOnlyList<Promotion>> GetActivePromotionsAsync(DateTime currentDate);
}