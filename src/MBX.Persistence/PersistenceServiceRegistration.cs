using MBX.Persistence.DatabaseContext;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MBX.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MbxDatabaseContext>(options => { options.UseSqlServer(configuration.GetConnectionString("MbxDatabaseConnectionString")); });

        return services;
    }
}