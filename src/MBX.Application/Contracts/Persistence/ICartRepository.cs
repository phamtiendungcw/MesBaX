using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface ICartRepository : IGenericRepository<Cart>
{
    Task<Cart> GetCartByCustomerIdAsync(Guid customerId);
    Task<Cart> GetCartBySessionIdAsync(string sessionId);
}