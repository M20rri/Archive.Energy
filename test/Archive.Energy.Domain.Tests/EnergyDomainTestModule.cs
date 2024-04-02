using Volo.Abp.Modularity;

namespace Archive.Energy;

[DependsOn(
    typeof(EnergyDomainModule),
    typeof(EnergyTestBaseModule)
)]
public class EnergyDomainTestModule : AbpModule
{

}
