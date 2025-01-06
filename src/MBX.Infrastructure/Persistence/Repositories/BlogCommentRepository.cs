using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class BlogCommentRepository : GenericRepository<BlogComment>, IBlogCommentRepository
{
    public BlogCommentRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<BlogComment>> GetCommentsByPostIdAsync(Guid postId, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.BlogComments
            .Where(bc => bc.PostId == postId && !bc.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<BlogComment>> GetCommentsByCustomerIdAsync(Guid customerId, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.BlogComments
            .Where(bc => bc.CustomerId == customerId && !bc.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}