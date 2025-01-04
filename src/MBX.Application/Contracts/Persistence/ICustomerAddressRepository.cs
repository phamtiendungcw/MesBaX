using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface ICustomerAddressRepository : IGenericRepository<CustomerAddress>
{
    Task<IReadOnlyList<CustomerAddress>> GetAddressesByCustomerIdAsync(Guid customerId);
}