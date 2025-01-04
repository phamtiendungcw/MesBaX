using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IWishlistRepository : IGenericRepository<WishList>
{
    Task<IReadOnlyList<WishList>> GetWishlistsByCustomerIdAsync(Guid customerId);
}