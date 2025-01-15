using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class WishlistRepository : GenericRepository<Wishlist>, IWishlistRepository
{
    public WishlistRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<Wishlist>> GetWishlistsByCustomerIdAsync(Guid customerId)
    {
        return await _context.Wishlists.Where(w => w.CustomerId == customerId && !w.IsDeleted).ToListAsync();
    }
}