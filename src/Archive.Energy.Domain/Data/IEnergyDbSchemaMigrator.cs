using System.Threading.Tasks;

namespace Archive.Energy.Data;

public interface IEnergyDbSchemaMigrator
{
    Task MigrateAsync();
}
