using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface ICustomerGroupRepository : IGenericRepository<CustomerGroup>
{
    Task<CustomerGroup> GetCustomerGroupByNameAsync(string groupName);
}