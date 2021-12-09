using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpVnextDemo.Data;
using Volo.Abp.DependencyInjection;

namespace AbpVnextDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpVnextDemoDbSchemaMigrator
        : IAbpVnextDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpVnextDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* 我们有意地从IServiceProvider解析AbpVnextDemoDbContext(而不是直接注入它)
             * 以正确地获得当前作用域中当前租户的连接字符串。
             */

            await _serviceProvider
                .GetRequiredService<AbpVnextDemoDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
