using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<OrderDetail>> GetOrderDetailsByOrderIdAsync(Guid orderId)
    {
        return await _context.OrderDetails.Where(od => od.OrderId == orderId).ToListAsync();
    }
}