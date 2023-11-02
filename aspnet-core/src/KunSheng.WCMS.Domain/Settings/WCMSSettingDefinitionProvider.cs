using Volo.Abp.Settings;

namespace KunSheng.WCMS.Settings;

public class WCMSSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(WCMSSettings.MySetting1));
    }
}
