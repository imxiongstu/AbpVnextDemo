using Volo.Abp.Settings;

namespace AbpVnextDemo.Settings
{
    public class AbpVnextDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //定义你自己的设置在这里. Example:
            //context.Add(new SettingDefinition(AbpVnextDemoSettings.MySetting1));
        }
    }
}
