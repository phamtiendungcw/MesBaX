using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface ICustomerRepository : IGenericRepository<Customer>
{
    Task<Customer> GetCustomerByEmailAsync(string email);
    Task<Customer> GetCustomerByPhoneNumberAsync(string phoneNumber);
    Task<IReadOnlyList<Customer>> GetCustomerByCreateDateAsync(DateTime dateTime, int pageNumber = 1, int pageSize = 10);
}