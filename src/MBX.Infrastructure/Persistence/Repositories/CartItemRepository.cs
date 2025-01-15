using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class CartItemRepository : GenericRepository<CartItem>, ICartItemRepository
{
    public CartItemRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<CartItem>> GetCartItemsByCartIdAsync(Guid cartId)
    {
        return await _context.CartItems.Where(ci => ci.CartId == cartId).ToListAsync();
    }
}