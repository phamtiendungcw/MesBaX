using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IBlogPostRepository : IGenericRepository<BlogPost>
{
    Task<IReadOnlyList<BlogPost>> GetBlogPostsByAuthorIdAsync(Guid authorId);
    Task<IReadOnlyList<BlogPost>> GetBlogPostsByPublishDateAsync(DateTime publishDate, int pageNumber = 1, int pageSize = 10);
    Task<BlogPost> GetBlogPostByTitleAsync(string title);
}