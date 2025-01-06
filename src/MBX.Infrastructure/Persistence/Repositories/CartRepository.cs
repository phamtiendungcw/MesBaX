using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class CartRepository : GenericRepository<Cart>, ICartRepository
{
    public CartRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<Cart> GetCartByCustomerIdAsync(Guid customerId)
    {
        return await _context.Carts.FirstOrDefaultAsync(c => c.CustomerId == customerId && !c.IsDeleted) ?? throw new NotFoundException(nameof(Cart), customerId);
    }

    public async Task<Cart> GetCartBySessionIdAsync(string sessionId)
    {
        return await _context.Carts.FirstOrDefaultAsync(c => c.SessionId == sessionId && !c.IsDeleted) ?? throw new NotFoundException(nameof(Cart), sessionId);
    }
}