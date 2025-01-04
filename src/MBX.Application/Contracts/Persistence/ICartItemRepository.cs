using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface ICartItemRepository : IGenericRepository<CartItem>
{
    Task<IReadOnlyList<CartItem>> GetCartItemsByCartIdAsync(Guid cartId);
}