using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<Category>> GetAllParentCategoriesAsync()
    {
        return await _context.Categories.Where(c => c.ParentCategoryId == null && !c.IsDeleted).ToListAsync();
    }

    public async Task<IReadOnlyList<Category>> GetSubcategoriesAsync(Guid parentCategoryId)
    {
        return await _context.Categories.Where(c => c.ParentCategoryId == parentCategoryId && !c.IsDeleted).ToListAsync();
    }

    public async Task<Category> GetCategoryByNameAsync(string categoryName)
    {
        return await _context.Categories.FirstOrDefaultAsync(c => c.CategoryName == categoryName && !c.IsDeleted) ?? throw new NotFoundException(nameof(Category), categoryName);
    }
}