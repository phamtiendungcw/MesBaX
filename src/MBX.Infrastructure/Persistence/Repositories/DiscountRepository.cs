using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class DiscountRepository : GenericRepository<Discount>, IDiscountRepository
{
    public DiscountRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<Discount>> GetActiveDiscountsAsync(DateTime currentDate)
    {
        return await _context.Discounts.Where(d => d.StartDate <= currentDate && d.EndDate >= currentDate && !d.IsDeleted).ToListAsync();
    }

    public async Task<Discount> GetDiscountByNameAsync(string name)
    {
        return await _context.Discounts.FirstOrDefaultAsync(d => d.DiscountName == name && !d.IsDeleted) ?? throw new NotFoundException(nameof(Discount), name);
    }

    public async Task<Discount> GetDiscountByCouponCodeAsync(string couponCode)
    {
        return await _context.Discounts.FirstOrDefaultAsync(d => d.CouponCode == couponCode && !d.IsDeleted) ?? throw new NotFoundException(nameof(Discount), couponCode);
    }
}