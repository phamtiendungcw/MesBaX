using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

namespace MBX.Infrastructure.Persistence.Repositories;

public class ProductAttributeRepository : GenericRepository<ProductAttribute>, IProductAttributeRepository
{
    public ProductAttributeRepository(MbxDatabaseContext context) : base(context)
    {
    }
}