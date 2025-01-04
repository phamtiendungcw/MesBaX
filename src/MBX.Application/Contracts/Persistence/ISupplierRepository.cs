using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface ISupplierRepository : IGenericRepository<Supplier>
{
    Task<Supplier> GetSupplierByNameAsync(string supplierName);
}