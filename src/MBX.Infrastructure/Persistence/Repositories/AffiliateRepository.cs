using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class AffiliateRepository : GenericRepository<Affiliate>, IAffiliateRepository
{
    public AffiliateRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<Affiliate> GetAffiliateByEmailAsync(string email)
    {
        return await _context.Affiliates.FirstOrDefaultAsync(a => a.Email == email && !a.IsDeleted) ?? throw new NotFoundException(nameof(Affiliate), email);
    }

    public async Task<Affiliate> GetAffiliateByUrlAsync(string url)
    {
        return await _context.Affiliates.FirstOrDefaultAsync(a => a.AffiliateUrl == url && !a.IsDeleted) ?? throw new NotFoundException(nameof(Discount), url);
    }
}