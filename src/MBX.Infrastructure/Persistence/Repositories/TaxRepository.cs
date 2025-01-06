using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class TaxRepository : GenericRepository<Tax>, ITaxRepository
{
    public TaxRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<Tax> GetTaxByNameAsync(string taxName)
    {
        return await _context.Taxes.FirstOrDefaultAsync(t => t.TaxName == taxName && !t.IsDeleted) ?? throw new NotFoundException(nameof(Discount), taxName);
    }
}