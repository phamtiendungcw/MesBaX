using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IReturnRequestRepository : IGenericRepository<ReturnRequest>
{
    Task<IReadOnlyList<ReturnRequest>> GetReturnRequestsByOrderIdAsync(Guid orderId, int pageNumber = 1, int pageSize = 20);
    Task<IReadOnlyList<ReturnRequest>> GetReturnRequestsByStatusAsync(string status, int pageNumber = 1, int pageSize = 20);
    Task<IReadOnlyList<ReturnRequest>> GetReturnRequestsByDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 20);
}