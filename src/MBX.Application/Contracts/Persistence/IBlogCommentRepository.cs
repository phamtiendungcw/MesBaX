using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface IBlogCommentRepository : IGenericRepository<BlogComment>
{
    Task<IReadOnlyList<BlogComment>> GetCommentsByPostIdAsync(Guid postId, int pageNumber = 1, int pageSize = 10);
    Task<IReadOnlyList<BlogComment>> GetCommentsByCustomerIdAsync(Guid customerId, int pageNumber = 1, int pageSize = 10);
}