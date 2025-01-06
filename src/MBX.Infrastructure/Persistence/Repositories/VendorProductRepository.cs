using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class VendorProductRepository : GenericRepository<VendorProduct>, IVendorProductRepository
{
    public VendorProductRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<VendorProduct>> GetProductsByVendorIdAsync(Guid vendorId)
    {
        return await _context.VendorProducts.Where(vp => vp.VendorId == vendorId && !vp.IsDeleted).ToListAsync();
    }
}