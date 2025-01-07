using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class CustomerGroupRepository : GenericRepository<CustomerGroup>, ICustomerGroupRepository
{
    public CustomerGroupRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<CustomerGroup> GetCustomerGroupByNameAsync(string groupName)
    {
        return await _context.CustomerGroups.FirstOrDefaultAsync(cg => cg.GroupName == groupName && !cg.IsDeleted) ?? throw new NotFoundException(nameof(CustomerGroup), groupName);
    }
}