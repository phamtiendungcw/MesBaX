using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<Order>> GetOrdersByCustomerIdAsync(Guid customerId, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Orders
            .Where(o => o.CustomerId == customerId && !o.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Order>> GetOrdersByStatusAsync(string status, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Orders
            .Where(o => o.OrderStatus == status && !o.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Order>> GetOrderByOrderDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Orders
            .Where(o => o.OrderDate == dateTime && !o.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Order>> GetOrderByShippedDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Orders
            .Where(o => o.ShippedDate == dateTime && !o.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Order>> GetOrderByOrderPaymentMethodAsync(string paymentMethod, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Orders
            .Where(o => o.PaymentMethod == paymentMethod && !o.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}