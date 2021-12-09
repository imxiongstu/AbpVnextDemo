using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpVnextDemo.Data
{
    /* 如果数据提供程序没有定义，则使用此。
     */
    public class NullAbpVnextDemoDbSchemaMigrator : IAbpVnextDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}