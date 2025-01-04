using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<IReadOnlyList<Product>> GetProductsByCategoryIdAsync(Guid categoryId);
    Task<IReadOnlyList<Product>> GetProductsBySupplierIdAsync(Guid supplierId);
    Task<IReadOnlyList<Product>> GetProductsByNameAsync(string name, int pageNumber = 1, int pageSize = 10);
    Task<IReadOnlyList<Product>> GetProductsByCreateDateAsync(DateTime dateTime);
    Task<IReadOnlyList<Product>> GetProductsByUpdateDateAsync(DateTime dateTime);
    Task<IReadOnlyList<Product>> GetProductsByDiscountIdAsync(Guid discountId);
    Task<Product> GetProductBySKUAsync(string sku);
}