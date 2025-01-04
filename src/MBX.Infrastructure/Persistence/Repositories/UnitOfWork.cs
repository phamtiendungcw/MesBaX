using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Common;
using MBX.Persistence.DatabaseContext;

namespace MBX.Infrastructure.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly MbxDatabaseContext _context;
    private readonly Dictionary<Type, object> _repositories;

    public UnitOfWork(MbxDatabaseContext context)
    {
        _context = context;
        _repositories = new Dictionary<Type, object>();
    }

    public IGenericRepository<T> Repository<T>() where T : BaseEntity
    {
        var entityType = typeof(T);

        if (!_repositories.ContainsKey(entityType)) _repositories[entityType] = new GenericRepository<T>(_context);

        return (IGenericRepository<T>)_repositories[entityType];
    }

    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}