using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IPaymentRepository : IGenericRepository<Payment>
{
    Task<IReadOnlyList<Payment>> GetPaymentsByOrderIdAsync(Guid orderId);

    Task<IReadOnlyList<Payment>> GetPaymentsByPaymentMethodAsync(string paymentMethod, int pageNumber = 1, int pageSize = 10);

    Task<IReadOnlyList<Payment>> GetPaymentsByDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 10);

    Task<IReadOnlyList<Payment>> GetPaymentsByStatusAsync(string status, int pageNumber = 1, int pageSize = 10);
}