using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Task<IReadOnlyList<Category>> GetAllParentCategoriesAsync();

    Task<IReadOnlyList<Category>> GetSubcategoriesAsync(Guid parentCategoryId);

    Task<Category> GetCategoryByNameAsync(string categoryName);
}