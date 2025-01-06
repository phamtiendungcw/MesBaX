using MBX.Application.Contracts.Persistence;
using MBX.Domain.Entities;
using MBX.Infrastructure.Persistence.Repositories.Common;
using MBX.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MBX.Infrastructure.Persistence.Repositories;

public class ProductAttributeValueRepository : GenericRepository<ProductAttributeValue>, IProductAttributeValueRepository
{
    public ProductAttributeValueRepository(MbxDatabaseContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<ProductAttributeValue>> GetProductAttributeValuesByAttributeIdAsync(Guid attributeId)
    {
        return await _context.ProductAttributeValues.Where(pav => pav.AttributeId == attributeId && !pav.IsDeleted).ToListAsync();
    }
}