using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<User> GetUserByUsernameAsync(string username)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Username == username && !u.IsDeleted) ?? throw new NotFoundException(nameof(Discount), username);
    }

    public async Task<User> GetUserByEmailAsync(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email && !u.IsDeleted) ?? throw new NotFoundException(nameof(Discount), email);
    }

    public async Task<IReadOnlyList<User>> GetUserByFirstNameAsync(string firstName, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Users
            .Where(u => u.FirstName == firstName && !u.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<User>> GetUserByLastNameAsync(string lastName, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Users
            .Where(u => u.LastName == lastName && !u.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<User>> GetUserByCreateDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Users
            .Where(u => u.CreatedAt == dateTime && !u.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}