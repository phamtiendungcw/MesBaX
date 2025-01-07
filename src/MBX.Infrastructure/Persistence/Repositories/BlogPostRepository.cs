using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class BlogPostRepository : GenericRepository<BlogPost>, IBlogPostRepository
{
    public BlogPostRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<BlogPost>> GetBlogPostsByAuthorIdAsync(Guid authorId)
    {
        return await _context.BlogPosts.Where(bp => bp.AuthorId == authorId && !bp.IsDeleted).ToListAsync();
    }

    public async Task<IReadOnlyList<BlogPost>> GetBlogPostsByPublishDateAsync(DateTime publishDate, int pageNumber = 1, int pageSize = 20)
    {
        return await _context.BlogPosts
            .Where(bp => bp.PublishDate == publishDate && !bp.IsDeleted)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<BlogPost> GetBlogPostByTitleAsync(string title)
    {
        return await _context.BlogPosts.FirstOrDefaultAsync(bp => bp.Title == title && !bp.IsDeleted) ?? throw new NotFoundException(nameof(BlogPost), title);
    }
}