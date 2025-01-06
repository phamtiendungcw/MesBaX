using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

namespace MBX.Infrastructure.Persistence.Repositories;

public class UserCustomerMappingRepository : GenericRepository<UserCustomerMapping>, IUserCustomerMappingRepository
{
    public UserCustomerMappingRepository(MbxDatabaseContext context) : base(context)
    {
    }
}