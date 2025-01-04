namespace MBX.Application.Contracts.Persistence.Common;

public interface IGenericRepository<T> where T : class
{
    Task<IReadOnlyList<T>> GetAllAsync(int pageNumber = 1, int pageSize = 20, bool includeDeleted = false);
    Task<T?> GetByIdAsync(Guid id, bool includeDeleted = false);
    Task<T> CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(Guid id);
    Task<bool> ExistsAsync(Guid id, bool includeDeleted = false);
}