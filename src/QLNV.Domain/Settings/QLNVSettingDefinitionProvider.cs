using Volo.Abp.Settings;

namespace QLNV.Settings;

public class QLNVSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(QLNVSettings.MySetting1));
    }
}
