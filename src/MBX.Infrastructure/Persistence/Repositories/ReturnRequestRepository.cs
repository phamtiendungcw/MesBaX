using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class ReturnRequestRepository : GenericRepository<ReturnRequest>, IReturnRequestRepository
{
    public ReturnRequestRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<ReturnRequest>> GetReturnRequestsByOrderIdAsync(Guid orderId, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.ReturnRequests
            .Where(rr => rr.OrderId == orderId && !rr.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<ReturnRequest>> GetReturnRequestsByStatusAsync(string status, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.ReturnRequests
            .Where(rr => rr.Status == status && !rr.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<ReturnRequest>> GetReturnRequestsByDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.ReturnRequests
            .Where(rr => rr.RequestDate == dateTime && !rr.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}