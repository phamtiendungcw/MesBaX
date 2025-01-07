using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<Product>> GetProductsByCategoryIdAsync(Guid categoryId)
    {
        return await _context.Products.Where(p => p.CategoryId == categoryId && !p.IsDeleted).ToListAsync();
    }

    public async Task<IReadOnlyList<Product>> GetProductsBySupplierIdAsync(Guid supplierId)
    {
        return await _context.Products.Where(p => p.SupplierId == supplierId && !p.IsDeleted).ToListAsync();
    }

    public async Task<IReadOnlyList<Product>> GetProductsByNameAsync(string name, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.Products
            .Where(p => p.ProductName.Contains(name) && !p.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Product>> GetProductsByCreateDateAsync(DateTime dateTime)
    {
        return await _context.Products.Where(p => p.CreatedAt == dateTime && !p.IsDeleted).ToListAsync();
    }

    public async Task<IReadOnlyList<Product>> GetProductsByUpdateDateAsync(DateTime dateTime)
    {
        return await _context.Products.Where(p => p.UpdatedDate == dateTime && !p.IsDeleted).ToListAsync();
    }

    public async Task<IReadOnlyList<Product>> GetProductsByDiscountIdAsync(Guid discountId)
    {
        return await _context.Products
            .Where(p => p.DiscountAppliedToProducts.Any(d => d.DiscountId == discountId) && !p.IsDeleted)
            .ToListAsync();
    }

    public async Task<Product> GetProductBySKUAsync(string sku)
    {
        return await _context.Products.FirstOrDefaultAsync(p => p.Sku == sku && !p.IsDeleted) ?? throw new NotFoundException(nameof(Discount), sku);
    }
}