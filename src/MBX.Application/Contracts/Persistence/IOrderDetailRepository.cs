using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IOrderDetailRepository : IGenericRepository<OrderDetail>
{
    Task<IReadOnlyList<OrderDetail>> GetOrderDetailsByOrderIdAsync(Guid orderId);
}