using Volo.Abp.Modularity;

namespace Archive.Energy;

/* Inherit from this class for your domain layer tests. */
public abstract class EnergyDomainTestBase<TStartupModule> : EnergyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
