using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class InventoryTransactionRepository : GenericRepository<InventoryTransaction>, IInventoryTransactionRepository
{
    public InventoryTransactionRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<InventoryTransaction>> GetInventoryTransactionsByProductIdAsync(Guid productId, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.InventoryTransactions
            .Where(it => it.ProductId == productId && !it.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<InventoryTransaction>> GetInventoryTransactionsByTypeAsync(string type, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.InventoryTransactions
            .Where(it => it.TransactionType == type && !it.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<InventoryTransaction>> GetInventoryTransactionsByDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.InventoryTransactions
            .Where(it => it.TransactionDate == dateTime && !it.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}