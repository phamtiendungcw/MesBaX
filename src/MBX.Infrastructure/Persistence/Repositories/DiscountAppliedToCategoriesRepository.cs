using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

namespace MBX.Infrastructure.Persistence.Repositories;

public class DiscountAppliedToCategoriesRepository : GenericRepository<DiscountAppliedToCategories>, IDiscountAppliedToCategoriesRepository
{
    public DiscountAppliedToCategoriesRepository(MbxDatabaseContext context) : base(context)
    {
    }
}