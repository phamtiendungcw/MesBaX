using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class VendorRepository : GenericRepository<Vendor>, IVendorRepository
{
    public VendorRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<Vendor> GetVendorByNameAsync(string name)
    {
        return await _context.Vendors.FirstOrDefaultAsync(v => v.VendorName == name && !v.IsDeleted) ?? throw new NotFoundException(nameof(Discount), name);
    }

    public async Task<IReadOnlyList<Vendor>> GetVendorsByCreatedDateAsync(DateTime createdDate, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Vendors
            .Where(v => v.CreatedAt == createdDate && !v.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Vendor>> GetVendorsByUpdatedDateAsync(DateTime updatedDate, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Vendors
            .Where(v => v.UpdatedDate == updatedDate && !v.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}