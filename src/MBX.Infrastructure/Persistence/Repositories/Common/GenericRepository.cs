using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories.Common;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly MbxDatabaseContext _context;

    public GenericRepository(MbxDatabaseContext context)
    {
        _context = context;
    }

    public async Task<T> CreateAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        return entity;
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity != null)
        {
            entity.IsDeleted = true;
            _context.Entry(entity).State = EntityState.Modified;
        }
    }

    public async Task UpdateAsync(T entity)
    {
        if (entity is BaseEntity baseEntity && baseEntity.Id == Guid.Empty)
            await _context.Set<T>().AddAsync(entity); //Add new entity
        else
            _context.Entry(entity).State = EntityState.Modified;
    }

    public async Task<IReadOnlyList<T>> GetAllAsync(int pageNumber = 1, int pageSize = 20, bool includeDeleted = false)
    {
        var query = _context.Set<T>().AsQueryable();
        if (!includeDeleted) query = query.Where(e => !e.IsDeleted);
        return await query.Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id, bool includeDeleted = false)
    {
        var query = _context.Set<T>().AsQueryable();
        if (!includeDeleted) query = query.Where(e => !e.IsDeleted);
        return await query.FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<bool> ExistsAsync(Guid id, bool includeDeleted = false)
    {
        var query = _context.Set<T>().AsQueryable();
        if (!includeDeleted) query = query.Where(e => !e.IsDeleted);
        return await query.AnyAsync(e => e.Id == id);
    }
}