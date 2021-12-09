using Microsoft.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace AbpVnextDemo.EntityFrameworkCore
{
    public static class AbpVnextDemoEfCoreEntityExtensionMappings
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            AbpVnextDemoGlobalFeatureConfigurator.Configure();
            AbpVnextDemoModuleExtensionConfigurator.Configure();

            OneTimeRunner.Run(() =>
            {
                /* 您可以为应用程序使用的模块中定义的实体配置额外属性。该类可用于将这些额外属性映射到数
                 * 据库中的表字段。使用这个类只配置ef核心相关的映射。使用AbpVnextDemoModuleExtensi
                 * onConfigurator类(在域。一个高级API为被使用的模块的实体定义额外的属性
                 *
                 * Example: Map a property to a table field:

                     ObjectExtensionManager.Instance
                         .MapEfCoreProperty<IdentityUser, string>(
                             "MyProperty",
                             (entityBuilder, propertyBuilder) =>
                             {
                                 propertyBuilder.HasMaxLength(128);
                             }
                         );

                 * See the documentation for more:
                 * https://docs.abp.io/en/abp/latest/Customizing-Application-Modules-Extending-Entities
                 */
            });
        }
    }
}
