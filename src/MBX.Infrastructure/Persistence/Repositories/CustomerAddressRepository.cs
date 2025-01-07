using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class CustomerAddressRepository : GenericRepository<CustomerAddress>, ICustomerAddressRepository
{
    public CustomerAddressRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<CustomerAddress>> GetAddressesByCustomerIdAsync(Guid customerId)
    {
        return await _context.CustomerAddresses.Where(ca => ca.CustomerId == customerId && !ca.IsDeleted).ToListAsync();
    }
}