using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpVnextDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpVnextDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpVnextDemo";
    }
}
