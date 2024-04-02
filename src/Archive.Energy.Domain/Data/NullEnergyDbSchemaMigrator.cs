using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Archive.Energy.Data;

/* This is used if database provider does't define
 * IEnergyDbSchemaMigrator implementation.
 */
public class NullEnergyDbSchemaMigrator : IEnergyDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
