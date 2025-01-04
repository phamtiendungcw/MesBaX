using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IUserRepository : IGenericRepository<User>
{
    Task<User> GetUserByUsernameAsync(string username);
    Task<User> GetUserByEmailAsync(string email);
    Task<IReadOnlyList<User>> GetUserByFirstNameAsync(string firstName, int pageNumber = 1, int pageSize = 10);
    Task<IReadOnlyList<User>> GetUserByLastNameAsync(string lastName, int pageNumber = 1, int pageSize = 10);
    Task<IReadOnlyList<User>> GetUserByCreateDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 10);
}