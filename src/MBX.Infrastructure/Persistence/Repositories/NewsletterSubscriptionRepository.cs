using MBX.Application.Contracts.Persistence;
using MBX.Application.Exceptions;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class NewsletterSubscriptionRepository : GenericRepository<NewsletterSubscription>, INewsletterSubscriptionRepository
{
    public NewsletterSubscriptionRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<NewsletterSubscription> GetSubscriptionByEmailAsync(string email)
    {
        return await _context.NewsletterSubscriptions.FirstOrDefaultAsync(ns => ns.Email == email && !ns.IsDeleted) ?? throw new NotFoundException(nameof(NewsletterSubscription), email);
    }
}