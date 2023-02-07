using Volo.Abp.Settings;

namespace LogTest.Settings;

public class LogTestSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LogTestSettings.MySetting1));
    }
}
