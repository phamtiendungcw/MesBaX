using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
{
    public PaymentRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<Payment>> GetPaymentsByOrderIdAsync(Guid orderId)
    {
        return await _context.Payments.Where(p => p.OrderId == orderId && !p.IsDeleted).ToListAsync();
    }

    public async Task<IReadOnlyList<Payment>> GetPaymentsByPaymentMethodAsync(string paymentMethod, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Payments
            .Where(p => p.PaymentMethod == paymentMethod && !p.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Payment>> GetPaymentsByDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Payments
            .Where(p => p.PaymentDate == dateTime && !p.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Payment>> GetPaymentsByStatusAsync(string status, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Payments
            .Where(p => p.Status == status && !p.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}