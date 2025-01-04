using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IVendorProductRepository : IGenericRepository<VendorProduct>
{
    Task<IReadOnlyList<VendorProduct>> GetProductsByVendorIdAsync(Guid vendorId);
}