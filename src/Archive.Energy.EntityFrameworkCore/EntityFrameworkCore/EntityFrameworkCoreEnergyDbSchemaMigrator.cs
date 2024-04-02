using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Archive.Energy.Data;
using Volo.Abp.DependencyInjection;

namespace Archive.Energy.EntityFrameworkCore;

public class EntityFrameworkCoreEnergyDbSchemaMigrator
    : IEnergyDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEnergyDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the EnergyDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EnergyDbContext>()
            .Database
            .MigrateAsync();
    }
}
