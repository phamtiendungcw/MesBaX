using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IOrderRepository : IGenericRepository<Order>
{
    Task<IReadOnlyList<Order>> GetOrdersByCustomerIdAsync(Guid customerId, int pageNumber = 1, int pageSize = 20);
    Task<IReadOnlyList<Order>> GetOrdersByStatusAsync(string status, int pageNumber = 1, int pageSize = 20);
    Task<IReadOnlyList<Order>> GetOrderByOrderDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 20);
    Task<IReadOnlyList<Order>> GetOrderByShippedDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 20);
    Task<IReadOnlyList<Order>> GetOrderByOrderPaymentMethodAsync(string paymentMethod, int pageNumber = 1, int pageSize = 20);
}