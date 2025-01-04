using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IVendorRepository : IGenericRepository<Vendor>
{
    Task<Vendor> GetVendorByNameAsync(string name);

    Task<IReadOnlyList<Vendor>> GetVendorsByCreatedDateAsync(DateTime createdDate, int pageNumber = 1, int pageSize = 10);

    Task<IReadOnlyList<Vendor>> GetVendorsByUpdatedDateAsync(DateTime updatedDate, int pageNumber = 1, int pageSize = 10);
}