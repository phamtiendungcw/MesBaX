using MBX.Application.Contracts.Persistence.Common;
using MBX.Domain.Entities;

namespace MBX.Application.Contracts.Persistence;

public interface INewsletterSubscriptionRepository : IGenericRepository<NewsletterSubscription>
{
    Task<NewsletterSubscription> GetSubscriptionByEmailAsync(string email);
}