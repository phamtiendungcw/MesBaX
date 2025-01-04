using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IShippingMethodRepository : IGenericRepository<ShippingMethod>
{
    Task<ShippingMethod> GetShippingMethodByNameAsync(string name);
}