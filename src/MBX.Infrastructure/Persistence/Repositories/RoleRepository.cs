using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class RoleRepository : GenericRepository<Role>, IRoleRepository
{
    public RoleRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<Role> GetRoleByNameAsync(string roleName)
    {
        return await _context.Roles.FirstOrDefaultAsync(r => r.RoleName == roleName && !r.IsDeleted) ?? throw new NotFoundException(nameof(Role), roleName);
    }
}