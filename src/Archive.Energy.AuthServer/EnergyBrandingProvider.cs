using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Archive.Energy;

[Dependency(ReplaceServices = true)]
public class EnergyBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Energy";
}
