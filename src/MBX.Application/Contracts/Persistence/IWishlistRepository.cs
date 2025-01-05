using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IWishlistRepository : IGenericRepository<Wishlist>
{
    Task<IReadOnlyList<Wishlist>> GetWishlistsByCustomerIdAsync(Guid customerId);
}