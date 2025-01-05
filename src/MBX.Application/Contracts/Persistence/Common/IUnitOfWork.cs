using MBX.Domain.Common;

namespace MBX.Application.Contracts.Persistence.Common
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> Repository<T>() where T : BaseEntity;
        Task<int> CompleteAsync();
    }
}