using Volo.Abp.Modularity;

namespace Archive.Energy;

public abstract class EnergyApplicationTestBase<TStartupModule> : EnergyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
