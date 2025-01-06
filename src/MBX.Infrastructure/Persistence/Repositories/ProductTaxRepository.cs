using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

namespace MBX.Infrastructure.Persistence.Repositories;

public class ProductTaxRepository : GenericRepository<ProductTax>, IProductTaxRepository
{
    public ProductTaxRepository(MbxDatabaseContext context) : base(context)
    {
    }
}