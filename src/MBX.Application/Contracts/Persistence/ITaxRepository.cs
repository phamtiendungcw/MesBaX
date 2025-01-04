using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface ITaxRepository : IGenericRepository<Tax>
{
    Task<Tax> GetTaxByNameAsync(string taxName);
}