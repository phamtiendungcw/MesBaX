using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class ShippingMethodRepository : GenericRepository<ShippingMethod>, IShippingMethodRepository
{
    public ShippingMethodRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<ShippingMethod> GetShippingMethodByNameAsync(string name)
    {
        return await _context.ShippingMethods.FirstOrDefaultAsync(sm => sm.Name == name && !sm.IsDeleted) ?? throw new NotFoundException(nameof(ShippingMethod), name);
    }
}