using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<Customer> GetCustomerByEmailAsync(string email)
    {
        return await _context.Customers.FirstOrDefaultAsync(c => c.Email == email && !c.IsDeleted) ?? throw new NotFoundException(nameof(Customer), email);
    }

    public async Task<Customer> GetCustomerByPhoneNumberAsync(string phoneNumber)
    {
        return await _context.Customers.FirstOrDefaultAsync(c => c.PhoneNumber == phoneNumber && !c.IsDeleted) ?? throw new NotFoundException(nameof(Customer), phoneNumber);
    }

    public async Task<IReadOnlyList<Customer>> GetCustomerByCreateDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Customers
            .Where(c => c.RegistrationDate == dateTime && !c.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}