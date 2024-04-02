using Volo.Abp.Modularity;

namespace Archive.Energy;

[DependsOn(
    typeof(EnergyApplicationModule),
    typeof(EnergyDomainTestModule)
)]
public class EnergyApplicationTestModule : AbpModule
{

}
