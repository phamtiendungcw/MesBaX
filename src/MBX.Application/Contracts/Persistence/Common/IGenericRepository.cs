namespace MBX.Application.Contracts.Persistence.Common;

public interface IGenericRepository<T> where T : class
{
    Task<IReadOnlyList<T>> GetAllAsync(int pageNumber = 1, int pageSize = 20);

    Task<T?> GetAsync(Guid id);

    Task<T> CreateAsync(T entity);

    Task UpdateAsync(T entity);

    Task DeleteAsync(Guid id);

    Task<bool> ExistsAsync(Guid id);
}