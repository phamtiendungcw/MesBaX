using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IdiscountRepository : IGenericRepository<Discount>
{
    Task<IReadOnlyList<Discount>> GetActiveDiscountsAsync(DateTime currentDate);
    Task<Discount> GetDiscountByNameAsync(string name);
    Task<Discount> GetDiscountByCouponCodeAsync(string couponCode);
}