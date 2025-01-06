using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;

namespace MBX.Infrastructure.Persistence.Repositories;

public class ProductAttributeMappingRepository : GenericRepository<ProductAttributeMapping>, IProductAttributeMappingRepository
{
    public ProductAttributeMappingRepository(MbxDatabaseContext context) : base(context)
    {
    }
}