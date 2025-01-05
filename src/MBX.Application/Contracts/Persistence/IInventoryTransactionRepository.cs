using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IInventoryTransactionRepository : IGenericRepository<InventoryTransaction>
{
    Task<IReadOnlyList<InventoryTransaction>> GetInventoryTransactionsByProductIdAsync(Guid productId, int pageNumber = 1, int pageSize = 10);
    Task<IReadOnlyList<InventoryTransaction>> GetInventoryTransactionsByTypeAsync(string type, int pageNumber = 1, int pageSize = 10);
    Task<IReadOnlyList<InventoryTransaction>> GetInventoryTransactionsByDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 10);
}