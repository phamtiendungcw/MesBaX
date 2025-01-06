using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

namespace MBX.Infrastructure.Persistence.Repositories;

public class CustomerCustomerGroupMappingRepository : GenericRepository<CustomerCustomerGroupMapping>, ICustomerCustomerGroupMappingRepository
{
    public CustomerCustomerGroupMappingRepository(MbxDatabaseContext context) : base(context)
    {
    }
}