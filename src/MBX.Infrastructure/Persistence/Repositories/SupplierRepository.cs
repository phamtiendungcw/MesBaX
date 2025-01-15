using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
{
    public SupplierRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<Supplier> GetSupplierByNameAsync(string supplierName)
    {
        return await _context.Suppliers.FirstOrDefaultAsync(s => s.SupplierName == supplierName && !s.IsDeleted) ?? throw new NotFoundException(nameof(Discount), supplierName);
    }
}