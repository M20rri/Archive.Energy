using Volo.Abp.Settings;

namespace Archive.Energy.Settings;

public class EnergySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EnergySettings.MySetting1));
    }
}
