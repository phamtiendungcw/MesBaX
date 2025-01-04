using MBX.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace MBX.Persistence.DatabaseContext
{
    public class MbxDatabaseContext : DbContext
    {
        private readonly ILogger<MbxDatabaseContext> _logger;
        public MbxDatabaseContext(DbContextOptions<MbxDatabaseContext> options, ILogger<MbxDatabaseContext> logger) : base(options)
        {
            _logger = logger;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply config for all entities from all assemblies
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MbxDatabaseContext).Assembly);

            // Soft Delete
            var entityTypes = modelBuilder.Model.GetEntityTypes()
                .Where(entityType => typeof(BaseEntity).IsAssignableFrom(entityType.ClrType));

            foreach (var entityType in entityTypes)
            {
                entityType.AddProperty("IsDeleted", typeof(bool));
                var parameter = Expression.Parameter(entityType.ClrType, "x");
                var propertyMethod = typeof(EF).GetMethod("Property")!.MakeGenericMethod(typeof(bool));
                var isDeletedProperty = Expression.Call(propertyMethod, parameter, Expression.Constant("IsDeleted"));
                var compareExpression = Expression.Equal(isDeletedProperty, Expression.Constant(false));
                var lambda = Expression.Lambda(compareExpression, parameter);
                modelBuilder.Entity(entityType.ClrType).HasQueryFilter(Expression.Lambda<Func<object, bool>>(lambda.Body, lambda.Parameters));
            }

            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            try
            {
                UpdateAuditFields();
                SoftDelete();
                return await base.SaveChangesAsync(cancellationToken);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error when save changes");
                throw; // Re-throw exception, handle in higher layer
            }
        }


        public override int SaveChanges()
        {
            try
            {
                UpdateAuditFields();
                SoftDelete();
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error when save changes");
                throw; // Re-throw exception, handle in higher layer
            }
        }


        private void SoftDelete()
        {
            var entries = ChangeTracker.Entries<BaseEntity>()
                 .Where(e => e.State == EntityState.Deleted);
            foreach (var entry in entries)
            {
                entry.State = EntityState.Modified;
                entry.Entity.IsDeleted = true;
            }
        }

        private void UpdateAuditFields()
        {
            var entries = ChangeTracker.Entries<BaseEntity>()
                  .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach (var entry in entries)
            {
                entry.Entity.DateModified = DateTime.UtcNow;
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.UtcNow;
                }
            }
        }
    }
}