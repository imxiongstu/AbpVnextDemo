using Volo.Abp.Threading;

namespace AbpVnextDemo
{
    public static class AbpVnextDemoGlobalFeatureConfigurator
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() =>
            {
                /* 您可以在这里配置(启用/禁用)所使用模块的全局特性.
                 *
                 * 如果你不需要，你可以安全地删除这个类并删除它的用法!
                 *
                 * Please refer to the documentation to lear more about the Global Features System:
                 * https://docs.abp.io/en/abp/latest/Global-Features
                 */
            });
        }
    }
}
